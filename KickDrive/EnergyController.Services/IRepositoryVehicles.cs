using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using EnergyController.Services.Controladores;

namespace EnergyController.Services
{
    public interface IRepositoryVehicles
    {
        public int InsertS(Vehicles vehicles);
        
    }
}
