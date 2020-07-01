using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;

namespace EnergyController.Services.Controladores
{
    public class ContVehicles : SQLRepository<Vehicles>, IRepositoryVehicles
    {
        public ContVehicles(AppDBContext context) : base(context) { }
        public int InsertS(Vehicles vehicles)
        {
            if (vehicles == null) throw new ArgumentNullException("Entity");
            entities.Add(vehicles);
            context.SaveChanges();
            return vehicles.Id;
        }
        public IEnumerable<Vehicles> GetVehicles()
        {
            return context.Set<Vehicles>().AsEnumerable();
        }
    }
}
