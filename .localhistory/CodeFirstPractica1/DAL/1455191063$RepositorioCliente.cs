﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class RepositorioCliente:RepositorioGenerico<Cliente>
    {
        public RepositorioCliente(EmpresaContext context) : base(context)
        {

        }
    }
}