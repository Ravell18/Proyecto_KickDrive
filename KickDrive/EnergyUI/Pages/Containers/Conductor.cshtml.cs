using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Services;
using EnergyController.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EnergyUI.Pages.Containers
{
    public class Index5Model : PageModel
    {
        [BindProperty]
        public Driver Driver { get; set; }
        public IRepositoryDriver repositoryDriver;

        public Index5Model(IRepositoryDriver repositoryDriver)
        {
            this.repositoryDriver = repositoryDriver;
        }

        public void OnPost()
        {
            repositoryDriver.InsertD(Driver);
        }

    }
}