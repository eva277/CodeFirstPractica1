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
            Visitas=new Collection<Visita>();
        }

        public int EquipoId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Contrato { get; set; }
        public string CondEspecial { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
