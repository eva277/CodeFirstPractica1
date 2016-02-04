using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Equipo
    {
        public Equipo()
        {
            Asistencias = new Collection<Asistencia>();
        }

        public virtual int EquipoId { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Contrato { get; set; }
        public virtual string CondEspecial { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Visita Visita { get; set; }
        public virtual int VisitaId { get; set; }
    }
}
