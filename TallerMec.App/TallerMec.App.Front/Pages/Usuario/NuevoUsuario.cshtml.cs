using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerMec.App.Front.Pages.Usuario
{
    public class NuevoUsuario : PageModel
    {
        private readonly ILogger<NuevoUsuario> _logger;

        public NuevoUsuario(ILogger<NuevoUsuario> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}