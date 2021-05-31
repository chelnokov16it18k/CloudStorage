using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CloudStorage.Models;
using System.IO;
using System;

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

        public IActionResult Upload() => View();

        [HttpPost]
        public IActionResult Upload(FileUploadViewModel pvm)
        {
            FileModel file = new FileModel();
            if (pvm.UploadedFile != null)
            {
                byte[] fileBytes = null;

                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.UploadedFile.OpenReadStream()))
                {
                    fileBytes = binaryReader.ReadBytes((int)pvm.UploadedFile.Length);
                }
                // установка массива байтов
                file.Content = fileBytes;
                file.Path = pvm.UploadedFile.FileName;
            }
            _context.Files.Add(file);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
            return RedirectToAction("Index");
        }
    }
}