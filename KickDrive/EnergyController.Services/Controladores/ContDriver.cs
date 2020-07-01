using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;

namespace EnergyController.Services.Controladores
{
    public class ContDriver : SQLRepository<Driver>, IRepositoryDriver
    {
        public ContDriver(AppDBContext context) : base(context) { }
        public int InsertD(Driver driver)
        {
            if (driver == null) throw new ArgumentNullException("Entity");
            entities.Add(driver);
            context.SaveChanges();
            return driver.Id;
        }
        public IEnumerable<Driver> GetDrivers()
        {
            return context.Set<Driver>().AsEnumerable();
        }
    }
}
