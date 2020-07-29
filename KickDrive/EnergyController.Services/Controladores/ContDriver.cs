using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public Driver Updates(Driver Drivers)
        {
            var temp = context.Drivers.FirstOrDefault(x => x.Id == Drivers.Id) ?? new Driver();
            if (temp.Id == 0)
                return temp;
            temp.Id = Drivers.Id;
            temp.DriverName = Drivers.DriverName;
            temp.INE = Drivers.INE;
            temp.License = Drivers.License;
            temp.NSS = Drivers.NSS;
            temp.Status = Drivers.Status;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public Driver Deletes(Driver Drivers)
        {
            var temp = context.Drivers.FirstOrDefault(x => x.Id == Drivers.Id) ?? new Driver();
            if (temp.Id == 0)
                return temp;
            temp.Id = Drivers.Id;
            temp.DriverName = Drivers.DriverName;
            temp.INE = Drivers.INE;
            temp.License = Drivers.License;
            temp.NSS = Drivers.NSS;
            temp.FrontPhoto = Drivers.FrontPhoto;
            temp.ProfilePhoto = Drivers.ProfilePhoto;
            temp.Status = Drivers.Status;
            if (temp == null) throw new ArgumentNullException("Entity");
            if (temp.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entities.Attach(temp);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return temp;
        }
        public Driver GetD(int Id)
        {
            return context.Drivers.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<Driver> GetDriver()
        {
            return context.Drivers.ToList() ?? new List<Driver>();
        }
    }
}
