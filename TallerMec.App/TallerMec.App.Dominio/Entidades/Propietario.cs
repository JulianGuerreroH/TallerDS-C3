using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMec.App.Dominio.Entidades
{
    public class Propietario: Persona
    {
        public string propietarioId {get; set;}
        //public string contrasenia {get; set;}
        public string correo {get; set;}
        public string fechaNacimiento {get; set;}
        public string ciudad {get; set;}
    }
}