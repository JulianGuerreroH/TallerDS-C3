using System.Globalization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMec.App.Persistencia.AppRepositorios;
using TallerMec.App.Dominio.Entidades;

namespace TallerMec.App.Front.Pages.JefeOperaciones
{
    public class GestionNuevoMecanico : PageModel
    {
        public static RepositorioMecanico repoMecanico = new RepositorioMecanico(
        new Persistencia.AppRepositorio.ContextDb()
        );
        public List<Mecanico> ListaMecanicos = new List<Mecanico>();

        public void OnGet()
        {
            this.ObtenerMecanicos();
        }
        private void ObtenerMecanicos() // con este metodo llenamos la lista creada inicialmente
        {
            foreach (var mecanico in repoMecanico.ObtenerMecanicos())
            {
                this.ListaMecanicos.Add(
                    new Mecanico()
                    {
                        mecanicoId = mecanico.mecanicoId,
                        nombre = mecanico.nombre,
                        telefono = mecanico.telefono,
                        nivelEstudio = mecanico.nivelEstudio,
                    }
                );
            }
        }
        public void OnPostAddMecanico(Mecanico mec)
        {
            try
            {
                Console.WriteLine("Agrego: " + mec.nombre);
                repoMecanico.AgregarMecanico(mec);
                this.ObtenerMecanicos();
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        public void OnPostDelete(string id)
        {
            repoMecanico.EliminarMecanico(id);
            this.ObtenerMecanicos();
        }

    }
}