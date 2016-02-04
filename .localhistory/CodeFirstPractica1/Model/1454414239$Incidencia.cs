using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Incidencia
    {
        public Incidencia()
        {
            
        }
        public virtual int IncidenciaId { get; set; }
        public virtual DateTime FechaIni { get; set; }
        public virtual DateTime FechaFin { get; set; }
        public virtual DateTime HoraIni { get; set; }
        public virtual DateTime HoraFin { get; set; }
        public virtual bool Concluido { get; set; }
        public virtual 
    }
}
