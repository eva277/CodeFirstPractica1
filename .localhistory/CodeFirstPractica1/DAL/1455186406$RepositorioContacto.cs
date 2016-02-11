using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class RepositorioContacto:RepositorioGenerico<Contacto>
    {
        public RepositorioContacto(EmpresaContext context) : base(context)
        {

        }
    }
}
