using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoseTrainerLibrary.Models
{
    public class User : IdentityUser
    {
        //public string Id { get; set; }
        //public string UserName { get; set; }
        //public string PasswordHash { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
