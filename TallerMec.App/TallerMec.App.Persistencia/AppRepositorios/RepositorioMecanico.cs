using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMec.App.Dominio.Entidades;
using TallerMec.App.Persistencia.AppRepositorio;

namespace TallerMec.App.Persistencia.AppRepositorios
{
    public class RepositorioMecanico
    {
        private readonly ContextDb dbContext;
        public RepositorioMecanico(ContextDb dbContext)
        {
            this.dbContext = dbContext;
        }
        public Mecanico AgregarMecanico(Mecanico mec)
        {
            var mecanicoNuevo = this.dbContext.Mecanics.Add(mec);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity;
        }
        public IEnumerable<Mecanico> ObtenerMecanicos()
        {
            return this.dbContext.Mecanics;
        }
        public Mecanico BuscarMecanico(string idMec)
        {
            return this.dbContext.Mecanics.FirstOrDefault(m => m.mecanicoId == idMec);
        }
        public void EditarMecanico(Mecanico mecanicoNuevo, string id)
        {
            var mecanicoActual = this.dbContext.Mecanics.FirstOrDefault(m => m.mecanicoId == id);
            if (mecanicoActual != null)
            {
                mecanicoActual.nombre = mecanicoNuevo.nombre;
                mecanicoActual.telefono = mecanicoNuevo.telefono;
                mecanicoActual.fechaNacimiento = mecanicoNuevo.fechaNacimiento;
                mecanicoActual.nivelEstudio = mecanicoNuevo.nivelEstudio;
                this.dbContext.SaveChanges();
            }
        }

        public void EliminarMecanico(string idMec)
        {
            var mecanicoEncontrado = this.dbContext.Mecanics.FirstOrDefault(m => m.mecanicoId == idMec);
            if (mecanicoEncontrado != null)
            {
                this.dbContext.Mecanics.Remove(mecanicoEncontrado);
                this.dbContext.SaveChanges();
            }
        }
    }
}