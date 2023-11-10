using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1372556_ProjetFinal.Models;

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

        public virtual DbSet<Changelog> Changelogs { get; set; } = null!;
        public virtual DbSet<Dresseur> Dresseurs { get; set; } = null!;
        public virtual DbSet<Generation> Generations { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Jeux> Jeuxes { get; set; } = null!;
        public virtual DbSet<Pokemon> Pokemons { get; set; } = null!;
        public virtual DbSet<Typee> Typees { get; set; } = null!;
        public virtual DbSet<VueJeux> VueJeuxes { get; set; } = null!;
        public virtual DbSet<PokemonDetailsResult> PokemonDetailsResult { get; set; }

        public virtual async Task<List<PokemonDetailsResult>> GetPokemonDetailsByGenerationAsync(int generationId)
        {
            return await PokemonDetailsResult
                .FromSqlInterpolated($"EXEC dbo.GetPokemonDetailsByGeneration {generationId}")
                .ToListAsync();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=BDPokemon");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Changelog>(entity =>
            {
                entity.Property(e => e.InstalledOn).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Dresseur>(entity =>
            {
                entity.HasKey(e => e.IdDresseur)
                    .HasName("PK__Dresseur__A18A2587980F19EE");
            });

            modelBuilder.Entity<Generation>(entity =>
            {
                entity.HasKey(e => e.IdGeneration)
                    .HasName("PK__Generati__B9B517B5516370F5");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Identifiant).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Jeux>(entity =>
            {
                entity.HasKey(e => e.IdJeux)
                    .HasName("PK__Jeux__1087CF568315B688");

                entity.HasOne(d => d.IdGenerationNavigation)
                    .WithMany(p => p.Jeuxes)
                    .HasForeignKey(d => d.IdGeneration)
                    .HasConstraintName("fk_Generation_jeux");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.IdPokemon)
                    .HasName("PK__Pokemon__653EBD853C86A24B");

                entity.HasOne(d => d.IdGenerationNavigation)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.IdGeneration)
                    .HasConstraintName("fk_Generation");

                entity.HasOne(d => d.IdTypesNavigation)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.IdTypes)
                    .HasConstraintName("fk_Types");
            });

            modelBuilder.Entity<Typee>(entity =>
            {
                entity.HasKey(e => e.IdTypes)
                    .HasName("PK__Typee__1DC79F821BE7076A");
            });

            modelBuilder.Entity<VueJeux>(entity =>
            {
                entity.ToView("VueJeux");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
