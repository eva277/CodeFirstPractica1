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
        public int ConexionId { get; set; }
        public string Parametro { get; set; }
        public string Valor { get; set; }
    }
}
