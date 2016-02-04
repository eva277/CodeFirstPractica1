using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Asistencia
    {
        public Asistencia()
        {

        }

        public virtual int AsistenciaId { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual DateTime FechaIni { get; set; }
        public virtual DateTime FechaFin { get; set; }
        public virtual DateTime HoraIni { get; set; }
        public virtual DateTime HoraFin { get; set; }
        public virtual Contacto Contacto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Equipo Equipo { get; set; }
        public virtual ICollection<Incidencia> Incidencia { get; set; }
    }
}
