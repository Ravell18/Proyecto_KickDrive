using EnergyController.Models;
using System;
using System.Collections.Generic;

namespace EnergyController.Services
{
    public class MockContainerRepository : IRepository
    {
        private List<Container> _containers;
        public MockContainerRepository()
        {
            _containers = new List<Container>() {
 new Container{ NombreC=" Chacsinkin", CanDEnvi = 160, ContainerId = 1, CMC =80, NCamiones = 50},
  new Container{ NombreC=" Tixcacalcupul", CanDEnvi = 320, ContainerId = 1, CMC =70, NCamiones = 60},
   new Container{ NombreC="Muxupip ", CanDEnvi = 240, ContainerId = 1, CMC =80, NCamiones = 30},
    new Container{ NombreC="Tixméhuac", CanDEnvi = 400, ContainerId = 1, CMC =80, NCamiones = 20},
 };
        }
        public IEnumerable<Container> GetAll()
        {
            return _containers;
        }

    }
}
