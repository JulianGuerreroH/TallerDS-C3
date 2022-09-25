using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerMec.App.Front.Pages.Mecanico
{
    public class NuevoMecanico : PageModel
    {
        private readonly ILogger<NuevoMecanico> _logger;

        public NuevoMecanico(ILogger<NuevoMecanico> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}