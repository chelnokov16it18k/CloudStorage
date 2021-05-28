using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorage.Models
{
    public class FileUploadViewModel
    {
        public IFormFile UploadedFile { get; set; }
    }
}
