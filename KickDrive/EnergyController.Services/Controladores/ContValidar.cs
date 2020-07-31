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
    public class ContValidar: SQLRepository<Logins>, IRepositoryValidar
    {
        public  ContValidar(AppDBContext context):base(context) { }
        public IEnumerable<Logins> GetLogins()
        {
            return context.Set<Logins>().AsEnumerable();
        }
        public int Validar(Logins logins)
        {
            var cuenta2 = context.Login.ToList();
            int i = 0;
            foreach (var items in cuenta2)
            {
                if (logins.Usuario == items.Usuario && logins.pass == items.pass)
                {
                    i = items.Id;
                    break;
                }

            }
            return i;
        } 
    }
}
