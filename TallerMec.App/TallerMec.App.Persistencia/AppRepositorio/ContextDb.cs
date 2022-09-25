using System.Reflection.Emit;
using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerMec.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using TallerMec.App.Persistencia.AppRepositorios;

namespace TallerMec.App.Persistencia.AppRepositorio
{
    public class ContextDb: DbContext
    {
        public virtual DbSet<Mecanico> Mecanics { get; set; }
        public virtual DbSet<Revision> Revisions { get; set; }
        public virtual DbSet<Vehiculo> vehiculos { get; set; }
        public virtual DbSet<Propietario> Propietarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=tcp:server-tallertic-eq.database.windows.net,1433;Initial Catalog=bd_tallertic;Persist Security Info=False;User ID=adminticeq;Password=contra-Admineq0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Oucrrió un error en OnConfiguring");
                throw;
            }
        }
    }
}