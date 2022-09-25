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
    }
}