using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorage.Models
{
    public class FilesContext: DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public FilesContext(DbContextOptions<FilesContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
