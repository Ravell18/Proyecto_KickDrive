using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Models
{
    public class ReportRoute
    {
        public int ReportId { get; set; }
        public string DriverName { get; set; }
        public int RouteId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

    }
}
