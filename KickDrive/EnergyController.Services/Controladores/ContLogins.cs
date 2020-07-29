using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;
using System.Linq;


namespace EnergyController.Services.Controladores
{
    public class ContLogins: SQLRepository<Logins>, IRepositoryLogins
    {
        public ContLogins(AppDBContext context) : base(context) { }
        public int InsertL(Logins logins)
        {
            if (logins == null) throw new ArgumentNullException("Entity");
            entities.Add(logins);
            context.SaveChanges();
            return logins.Id;
        }

    }
}
