using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class RepositorioConexion:RepositorioGenerico<Conexion>
    {
        public RepositorioConexion(EmpresaContext context) : base(context)
        {

        }
    }
}
