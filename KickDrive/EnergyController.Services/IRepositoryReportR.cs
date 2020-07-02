using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Services.Controladores;
using EnergyController.Models;

namespace EnergyController.Services
{
     public interface IRepositoryReportR
    {
        public int InsertRR(ReportRoute reportRoute);
    }
}
