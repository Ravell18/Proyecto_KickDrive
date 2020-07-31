using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EnergyController.Models;


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
