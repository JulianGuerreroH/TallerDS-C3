using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMec.App.Dominio.Entidades;
using TallerMec.App.Persistencia.AppRepositorio;

namespace TallerMec.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietario
    {
        private readonly ContextDb dbContext;
        public RepositorioPropietario(ContextDb dbContext)
        {
            this.dbContext = dbContext;
        }
        public Propietario AgregarPropietario(Propietario mec)
        {
            var propietarioNuevo = this.dbContext.Propietarios.Add(mec);
            this.dbContext.SaveChanges();
            return propietarioNuevo.Entity;
        }
        public IEnumerable<Propietario> ObtenerPropietarios()
        {
            return this.dbContext.Propietarios;
        }
    }
}