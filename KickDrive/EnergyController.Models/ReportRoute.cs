using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyController.Models
{
    public class ReportRoute:BaseEntity
    {
        public string DriverName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        //Referencias
        //Driver
        [Display(Name = "Routes")]
        [Required(ErrorMessage = "Routes is required.")]
        [ForeignKey("Routes")]
        public int? RoutesId { get; set; }
        public Routes Routes { get; set; }

    }
}
