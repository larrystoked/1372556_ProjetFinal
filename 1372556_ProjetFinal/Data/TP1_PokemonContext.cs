using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1372556_ProjetFinal.Models;
using _1372556_ProjetFinal.ViewModels;
using _1372556_ProjetFinal.ViewModel;

namespace _1372556_ProjetFinal.Data
{
    public partial class TP1_PokemonContext : DbContext
    {
        public TP1_PokemonContext()
        {
        }

        public TP1_PokemonContext(DbContextOptions<TP1_PokemonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dresseur> Dresseurs { get; set; } = null!;
        public virtual DbSet<Generation> Generations { get; set; } = null!;
        public virtual DbSet<Jeux> Jeuxes { get; set; } = null!;
        public virtual DbSet<Pokemon> Pokemons { get; set; } = null!;
        public virtual DbSet<Types> Types { get; set; } = null!;
        public virtual DbSet<JeuxComplexViewModel> JeuxComplexs { get; set; } = null!;
        public virtual DbSet<VwListeJeux> ListeJeux { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=BDPokemon");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JeuxComplexViewModel>().HasNoKey();

            modelBuilder.Entity<Dresseur>(entity =>
            {
                entity.HasKey(e => e.IdDresseur)
                    .HasName("PK__Dresseur__A18A258796FF75EA");
            });

            modelBuilder.Entity<Generation>(entity =>
            {
                entity.HasKey(e => e.IdGeneration)
                    .HasName("PK__Generati__B9B517B5C22F9B78");
            });

            modelBuilder.Entity<Jeux>(entity =>
            {
                entity.HasKey(e => e.IdJeux)
                    .HasName("PK__Jeux__1087CF56308CDE1D");

                entity.HasOne(d => d.IdGenerationNavigation)
                    .WithMany(p => p.Jeuxes)
                    .HasForeignKey(d => d.IdGeneration)
                    .HasConstraintName("fk_Generation_jeux");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.IdPokemon)
                    .HasName("PK__Pokemon__653EBD85BAB59545");

                entity.Property(e => e.NiveauParDefaut).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdGenerationNavigation)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.IdGeneration)
                    .HasConstraintName("fk_Generation");

                entity.HasMany(d => d.IdDresseurs)
                    .WithMany(p => p.IdPokemons)
                    .UsingEntity<Dictionary<string, object>>(
                        "PokemonDresseur",
                        l => l.HasOne<Dresseur>().WithMany().HasForeignKey("IdDresseur").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_Dresseur"),
                        r => r.HasOne<Pokemon>().WithMany().HasForeignKey("IdPokemon").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_Pokemon"),
                        j =>
                        {
                            j.HasKey("IdPokemon", "IdDresseur").HasName("PK__Pokemon___0F261FDD8599F6D7");

                            j.ToTable("Pokemon_Dresseur");

                            j.IndexerProperty<int>("IdPokemon").HasColumnName("idPokemon");

                            j.IndexerProperty<int>("IdDresseur").HasColumnName("idDresseur");
                        });

                entity.HasMany(d => d.IdTypes)
                    .WithMany(p => p.IdPokemons)
                    .UsingEntity<Dictionary<string, object>>(
                        "PokemonTypes",
                        l => l.HasOne<Types>().WithMany().HasForeignKey("IdTypes").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_Type"),
                        r => r.HasOne<Pokemon>().WithMany().HasForeignKey("IdPokemon").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_Pokemon_type"),
                        j =>
                        {
                            j.HasKey("IdPokemon", "IdTypes").HasName("PK__PokemonT__1185253979228652");

                            j.ToTable("PokemonTypes");

                            j.IndexerProperty<int>("IdPokemon").HasColumnName("idPokemon");

                            j.IndexerProperty<int>("IdTypes").HasColumnName("idTypes");
                        });
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasKey(e => e.IdTypes)
                    .HasName("PK__Type__4BB98BC6ED3EF932");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
