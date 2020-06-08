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
 
        }
        public IEnumerable<Container> GetAll()
        {
            return _containers;
        }

    }
}
