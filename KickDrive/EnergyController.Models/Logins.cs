using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EnergyController.Models
{
    public class Logins:BaseEntity
    {
        [Required(ErrorMessage = "User is required")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string pass { get; set; }
    }
}
