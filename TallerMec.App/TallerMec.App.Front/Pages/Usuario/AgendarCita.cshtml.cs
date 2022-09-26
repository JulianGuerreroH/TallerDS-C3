using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TallerMec.App.Front.Pages.Usuario
{
    public class AgendarCita : PageModel
    {
        private readonly ILogger<AgendarCita> _logger;

        public AgendarCita(ILogger<AgendarCita> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}