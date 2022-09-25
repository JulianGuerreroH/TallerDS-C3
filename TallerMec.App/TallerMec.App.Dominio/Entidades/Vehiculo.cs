using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMec.App.Dominio.Entidades
{
    public class Vehiculo
    {
        public string vehiculoId {get; set;}
        public string modelo {get; set;}
        public string tipoVehiculo {get; set;}
        public string marca {get; set;}
        public string capacidad {get; set;}
        public string cilindraje {get; set;}
        public string ciudadOrigen {get; set;}
        //public string accesorios {get; set;}
        //public string mecanicoId {get; set;}
        public string propietarioId {get; set;}
    }
}