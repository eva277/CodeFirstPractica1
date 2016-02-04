using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Tareas
    {
        public Tareas()
        {

        }

        public virtual int TareasId { get; set; }
        public virtual DateTime HoraIni { get; set; }
        public virtual DateTime FechaIni { get; set; }
        public virtual int Prioridad { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual bool Concluido { get; set; }
        public virtual bool Propia { get; set; }
        public virtual int Progreso { get; set; }

    }
}
