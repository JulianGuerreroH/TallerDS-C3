using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using System;
using TallerMec.App.Persistencia.AppRepositorios;
using TallerMec.App.Persistencia.AppRepositorio;
using TallerMec.App.Dominio.Entidades;

namespace TallerMec.App.Consola
{
    class Program
    {
        public static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.AppRepositorio.ContextDb()
        );
         static void Main(string[] args)
        {
            Console.WriteLine("");
            //Console.WriteLine("Imprimiento desde la consola");
            AgregarMecanico(); //llamamos el metodo en el main, esto es lo que se hace en el front
            //ObtenerMecanicos();
            //BuscarMecanico("30");
            //EditarMecanico("23");
            //EliminarMecanico("30");
        }

        static void AgregarMecanico(){
            var mecanico = new Mecanico{
                mecanicoId = "1",
                nombre = "Carlos",
                nivelEstudio = "Bachillerato",
                telefono = "123456"
            };
            repoMecanico.AgregarMecanico(mecanico);
        }
    }
}