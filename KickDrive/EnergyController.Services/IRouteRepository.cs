using EnergyController.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyController.Services
{
    public interface IRouteRepository: IRepository<Routes>
    {
        IEnumerable<Driver> GetDrivers();
        IEnumerable<Vehicles> GetVehicles();
    }

}
