using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMec.App.Dominio.Entidades;
using TallerMec.App.Persistencia.AppRepositorio;

namespace TallerMec.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculo
    {
        private readonly ContextDb dbContext;
        public RepositorioVehiculo(ContextDb dbContext)
        {
            this.dbContext = dbContext;
        }
        public Vehiculo AgregarVehiculo(Vehiculo vehiculo)
        {
            var VehiculoNuevo = this.dbContext.Vehiculos.Add(vehiculo);
            this.dbContext.SaveChanges();
            return VehiculoNuevo.Entity;
        }
        public IEnumerable<Vehiculo> ObtenerVehiculos()
        {
            return this.dbContext.Vehiculos;
        }
        public Vehiculo BuscarVehiculo(string idVehiculo)
        {
            return this.dbContext.Vehiculos.FirstOrDefault(v => v.vehiculoId == idVehiculo);
        }
        
        // public void EditarVehiculo(Vehiculo vehiculoNuevo, string placa)
        // {
        //     var vehiculoActual = this.dbContext.Vehiculos.FirstOrDefault(v => v.vehiculoId == placa);
        //     if (vehiculoActual != null)
        //     {
        //         vehiculoActual.nombre = vehiculoNuevo.nombre;
        //         vehiculoActual.telefono = vehiculoNuevo.telefono;
        //         vehiculoActual.nivelEstudio = vehiculoNuevo.nivelEstudio;
        //         this.dbContext.SaveChanges();
        //     }
        // }

        // public void EliminarMecanico(string idMec)
        // {
        //     var mecanicoEncontrado = this.dbContext.Mecanics.FirstOrDefault(m => m.mecanicoId == idMec);
        //     if (mecanicoEncontrado != null)
        //     {
        //         this.dbContext.Mecanics.Remove(mecanicoEncontrado);
        //         this.dbContext.SaveChanges();
        //     }
        // }
    }
}