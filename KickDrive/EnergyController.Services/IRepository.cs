using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;

namespace EnergyController.Services
{
    public interface IRepository
    {
        public IEnumerable<Container> GetAll();
    }
}
