using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Conexion
    {
        public Conexion()
        {

        }
        public virtual int ConexionId { get; set; }
        public virtual string Parametro { get; set; }
        public virtual string Valor { get; set; }
    }
}
