using CodeFirstPractica1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    [PropertyChanged.ImplementPropertyChanged]

    public class Incidencia : PropertyValidateModel
    {
        public Incidencia()
        {
            
        }
        public int IncidenciaId { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraIni { get; set; }
        public DateTime HoraFin { get; set; }
        public bool Concluido { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
    }
}
