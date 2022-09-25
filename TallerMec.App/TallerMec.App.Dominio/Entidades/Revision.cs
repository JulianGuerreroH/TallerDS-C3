using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerMec.App.Dominio.Entidades
{
    public class Revision
    {
        public string revisionId {get; set;}
        public string fechaRev { get; set; }
        //public string vehiculoId {get; set;}
        public string mecanicoId { get; set; }
        public string vehiculoId { get; set; }

    }
}