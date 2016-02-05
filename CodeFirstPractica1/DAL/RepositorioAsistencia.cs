using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class RepositorioAsistencia:RepositorioGenerico<Asistencia>
    {
        public RepositorioAsistencia(EmpresaContext context) : base(context)
        {

        }
    }
}
