// ImageController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _1372556_ProjetFinal.Data;
using _1372556_ProjetFinal.Models;
using _1372556_ProjetFinal.ViewModels;
using Microsoft.Extensions.Logging;

namespace _1372556_ProjetFinal.Controllers
{
    public class ImageController : Controller
    {
        private readonly TP1_PokemonContext _context;

        public ImageController(TP1_PokemonContext context)
        {
            _context = context;
        }

        // ... autres actions
        [HttpGet]
        public async Task<IActionResult> AjouterImage()
        {
            
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AjouterImage(ImageUploadViewModel iuvm)
        {
            if (ModelState.IsValid)
            {
                MemoryStream stream = new MemoryStream();
                await iuvm.FormFile.CopyToAsync(stream);
                byte[] fichierImage = stream.ToArray();

                // Créer une instance de l'entité Image et ajouter les données de l'image
                Image nouvelleImage = new Image { FichierImage = fichierImage };
                _context.Images.Add(nouvelleImage);
                await _context.SaveChangesAsync();

                // Rediriger vers la vue AfficherImages avec la liste des images
                return RedirectToAction("AfficherImages");
            }

            // En cas d'erreur, revenir à la vue AjouterImage
            return View(iuvm);
        }

        public IActionResult AfficherImages()
        {
            // Récupérer la liste des images depuis la base de données
            List<Image> images = _context.Images.ToList();

            // Passer la liste des images à la vue
            return View(images);
        }


    }
}
