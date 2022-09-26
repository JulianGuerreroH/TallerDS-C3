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
    public class BuscarPlaca : PageModel
    {
        public static RepositorioVehiculo repoVehiculo = new RepositorioVehiculo(
        new Persistencia.AppRepositorio.ContextDb()
        );
        public static RepositorioPropietario repoPropietario = new RepositorioPropietario(
        new Persistencia.AppRepositorio.ContextDb()
        );
        //public List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
        public Vehiculo vehiculo = new Vehiculo();
        public Propietario propietario = new Propietario();

        public void OnPostBuscarPlaca(string vehiculoId)
        {
            try
            {
                var v = repoVehiculo.BuscarVehiculo(vehiculoId);
                Console.WriteLine("Se busco: " + v.modelo);
                vehiculo.vehiculoId = v.vehiculoId;
                vehiculo.modelo = v.modelo;
                vehiculo.tipoVehiculo = v.tipoVehiculo;
                vehiculo.marca = v.marca;
                vehiculo.capacidad = v.capacidad;
                vehiculo.cilindraje = v.cilindraje;
                vehiculo.ciudadOrigen = v.ciudadOrigen;
                vehiculo.propietarioId = v.propietarioId;

                var p = repoPropietario.BuscarPropietario(v.propietarioId);
                Console.WriteLine("Se busco: " + p.nombre);
                propietario.nombre = p.nombre;
                propietario.telefono = p.telefono;
                propietario.correo = p.correo;
                propietario.fechaNacimiento = p.fechaNacimiento;
                propietario.ciudad = p.ciudad;

            }
            catch (System.Exception)
            {
                throw;
            }

        }

        // public void OnGet()
        // {
        //     this.ObtenerVehiculos();
        // }
        // private void ObtenerVehiculos() // con este metodo llenamos la lista creada inicialmente
        // {
        //     foreach (var vehiculo in repoVehiculo.ObtenerVehiculos())
        //     {
        //         this.ListaVehiculos.Add(
        //             new Vehiculo()
        //             {
        //                 mecanicoId = mecanico.mecanicoId,
        //                 nombre = mecanico.nombre,
        //                 telefono = mecanico.telefono,
        //                 nivelEstudio = mecanico.nivelEstudio,
        //             }
        //         );
        //     }
        // }
    }
}