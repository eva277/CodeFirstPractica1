﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Equipo
    {
        public Equipo()
        {

        }

        public virtual int EquipoId { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Contrato { get; set; }
        public virtual string CondEspecial { get; set; }
    }
}
