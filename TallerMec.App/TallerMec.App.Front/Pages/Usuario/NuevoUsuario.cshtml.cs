using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TallerMec.App.Dominio.Entidades;
using TallerMec.App.Persistencia.AppRepositorios;

namespace TallerMec.App.Front.Pages.Usuario
{
    public class NuevoUsuario : PageModel
    {
        public static RepositorioPropietario repoPropietario = new RepositorioPropietario(
        new Persistencia.AppRepositorio.ContextDb()
        );
        public static RepositorioVehiculo repoVehiculo = new RepositorioVehiculo(
        new Persistencia.AppRepositorio.ContextDb()
        );
        public List<Propietario> ListaPropietarios = new List<Propietario>();
        public List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

        public void OnGet()
        {
            this.ObtenerPropietarios();
        }
        private void ObtenerPropietarios() // con este metodo llenamos la lista creada inicialmente
        {
            foreach (var propietario in repoPropietario.ObtenerPropietarios())
            {
                this.ListaPropietarios.Add(
                    new Propietario()
                    {
                        nombre = propietario.nombre,
                        propietarioId = propietario.propietarioId,
                        fechaNacimiento = propietario.fechaNacimiento,
                        telefono = propietario.telefono,
                        correo = propietario.correo,
                        ciudad = propietario.ciudad,
                    }
                );
            }
        }
        public void OnPostAdd(Propietario propietario, Vehiculo vehiculo)
        {
            try
            {
                repoPropietario.AgregarPropietario(propietario);
                repoVehiculo.AgregarVehiculo(vehiculo);
                this.ObtenerPropietarios();
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}