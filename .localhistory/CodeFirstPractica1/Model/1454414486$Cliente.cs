﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public virtual int ClienteId { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellidos { get; set; }
        public virtual string nombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }

        public virtual string Descripcion { get; set; }
        public virtual int CodPostal { get; set; }
        public virtual string Clase {get;set;}
        public virtual string TlfnCentralita { get; set; }

    }
}