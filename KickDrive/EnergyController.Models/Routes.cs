using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EnergyController.Models
{
    public class Routes
    {
        public int RouteId { get; set; }
        public string Date { get; set; }
        public string NameSup { get; set; }
        public int NumSup { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public string Incidents { get; set; }
        public string timeE { get; set; }
        public string timeS { get; set; }
        public string NYES { get; set; }
        public string Adults { get; set; }
        
    }
}
