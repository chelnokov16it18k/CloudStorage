using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CloudStorage.Models;
using System.IO;

namespace FileUploadApp.Controllers
{
    public class FilesController : Controller
    {
        FilesContext _context;

        public FilesController(FilesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Files.ToList());
        }

        [HttpPost]
        public IActionResult Upload(FileUploadViewModel pvm)
        {
            FileModel file = new FileModel();
            if (pvm.UploadedFile != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.UploadedFile.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.UploadedFile.Length);
                }
                // установка массива байтов
                file.content = imageData;
            }
            _context.Files.Add(file);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}