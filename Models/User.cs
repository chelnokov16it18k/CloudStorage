using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudStorage.Models
{
    public class User : IdentityUser
    {
        public String Name { get; set; }
        public int Year { get; set; }
        public byte[] UserPic { get; set; }
    }
}
