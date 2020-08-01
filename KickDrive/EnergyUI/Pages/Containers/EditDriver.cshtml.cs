using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;
using EnergyController.Services.Controladores;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EnergyUI.Pages.Containers
{
    public class EditDriverModel : PageModel
    {
        [BindProperty]
        public Driver Driverss { get; private set; }
        public SelectList conductores { get; private set; }
        public IRepositoryDriver repositoryDriver;
        public EditDriverModel(IRepositoryDriver repositoryDriver)
        {
            this.repositoryDriver = repositoryDriver;
        }
        public void OnGet(int Id)
        {
            Driverss = repositoryDriver.GetD(Id);
            conductores = new SelectList(repositoryDriver.GetDriver(), nameof(Driverss.Id),
            nameof(Driverss.DriverName));
        }
        public IActionResult OnPost(Driver Drivers)
        {
            Driverss = repositoryDriver.Updates(Drivers);
            return Page();
        }

    }
}
