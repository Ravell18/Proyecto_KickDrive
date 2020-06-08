using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string INE { get; set; }
        public string License { get; set; }
        public int NSS { get; set; }
        public string FrontPhoto { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
