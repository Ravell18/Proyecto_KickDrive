using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyController.Models;
using EnergyController.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnergyUI.Pages.Containers
{
    public class IndexModel : PageModel
    {
        private readonly IRepository repository;
        public IEnumerable<Container> Containers { get; set; }
        public IndexModel(IRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet()
        {
            Containers = repository.GetAll();
        }


    }
}