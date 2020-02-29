using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoseTrainer.ViewModels
{
    public class RegisterVM
    {
        [DisplayName("Nume de utilizator")]
        public string UserName { get; set; }

        [DisplayName("Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Reintrodu parola")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
