using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EnergyController.Models;
using EnergyController.Services;

namespace EnergyUI.Pages.Containers
{
    public class Index3Model : PageModel
    {
        private readonly IRepository<Routes> repository;
        public IEnumerable<Routes> Routes { get; private set; }
        public Index3Model(IRepository<Routes> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet()
        {
            try
            {
                Routes = repository.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFount");
            }
        }
    }
}