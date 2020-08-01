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
    public class EditVehiclesModel : PageModel
    {
        [BindProperty]
        public Vehicles Vehicle { get; private set; }
        public SelectList vehiculos {get; private set;}
    public IRepositoryVehicles repositoryVehicles;
    public EditVehiclesModel(IRepositoryVehicles repositoryVehicles)
    {
        this.repositoryVehicles = repositoryVehicles;
    }
    public void OnGet(int Id)
    {
        Vehicle = repositoryVehicles.GetVehicles(Id);
            vehiculos = new SelectList(repositoryVehicles.GetV(), nameof(Vehicle.Id),
            nameof(Vehicle.NProp));
    }
    public IActionResult OnPost(Vehicles vehicles)
    {
        Vehicle = repositoryVehicles.Updates(vehicles);
        return Page();
    }
    
    }
}