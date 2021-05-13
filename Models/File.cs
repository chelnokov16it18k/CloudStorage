using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorage.Models
{
    public class File
    {
        public int Id { get; set; }

        public byte[] Content { get; set; }

        [Display(Name = "Имя файла")]
        public string Name { get; set; }

        [Display(Name = "Путь")]
        public string Path { get; set; }

        [Display(Name = "Размер (байты)")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long Size { get; set; }


    }
}
