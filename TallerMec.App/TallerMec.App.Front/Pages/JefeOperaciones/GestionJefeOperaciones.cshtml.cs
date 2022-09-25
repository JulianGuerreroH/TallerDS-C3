using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TallerMec.App.Persistencia.AppRepositorios;
using TallerMec.App.Dominio.Entidades;

namespace TallerMec.App.Front.Pages.JefeOperaciones
{
    public class GestionJefeOperaciones : PageModel
    {
       public static RepositorioVehiculo repoVehiculo = new RepositorioVehiculo(
        new Persistencia.AppRepositorio.ContextDb()
        );
        public List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

        public void OnGet()
        {
            this.ObtenerVehiculos();
        }
        private void ObtenerVehiculos() // con este metodo llenamos la lista creada inicialmente
        {
            foreach (var Vehiculo in repoVehiculo.ObtenerVehiculos())
            {
                this.ListaVehiculos.Add(
                    new Vehiculo()
                    {
                        vehiculoId = Vehiculo.vehiculoId,
                        tipoVehiculo = Vehiculo.tipoVehiculo,
                        modelo = Vehiculo.modelo,
                        capacidad = Vehiculo.capacidad,
                        
                    }
                );
            }
        }
    }
}