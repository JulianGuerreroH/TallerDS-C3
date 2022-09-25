using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerMec.App.Front.Pages.JefeOperaciones
{
    public class GestionMecanico : PageModel
    {
        private readonly ILogger<GestionMecanico> _logger;

        public GestionMecanico(ILogger<GestionMecanico> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}