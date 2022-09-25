using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMec.App.Dominio.Entidades
{
    public class Mecanico: Persona
    {
        public string mecanicoId { get; set; }
        public string nivelEstudio {get; set;}
        public string vehiculoId {get; set;}
        public string revisionId {get; set;}
    }
}