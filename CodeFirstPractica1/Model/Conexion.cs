using CodeFirstPractica1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    [PropertyChanged.ImplementPropertyChanged]

    public class Conexion : PropertyValidateModel
    {

        public Conexion()
        {

        }
        public int ConexionId { get; set; }
        public string Parametro { get; set; }
        public string Valor { get; set; }
    }
}
