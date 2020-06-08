using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public class Vehicles
    {
        public int VehicleId { get; set; }
        public string Date { get; set; }
        public int NProp { get; set; }
        public string Brand { get; set; }
        public int NSerie { get; set; }
        public string Model { get; set; }
        public string TipServ { get; set; }
        public int NMotor { get; set; }
        public string TComb { get; set; }
        public string DocLeg { get; set; }
        public string TipLlantas { get; set; }
        public int CapPerson {get;set;}
        public int CapTon { get; set; }
        public int Placas { get; set; }
        public string OfExp { get; set; }
        public int NRegist { get; set; }
    }
}
