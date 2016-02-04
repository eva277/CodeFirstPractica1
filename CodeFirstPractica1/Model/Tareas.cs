using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstPractica1.Model
{
    public class Tareas
    {
        public Tareas()
        {

        }

        public virtual int TareasId { get; set; }
        [Required]

        public virtual DateTime HoraIni { get; set; }
        [Required]

        public virtual DateTime FechaIni { get; set; }
        [Required]

        public virtual int Prioridad { get; set; }
        public virtual string Descripcion { get; set; }
        [Required]

        public virtual bool Concluido { get; set; }
        public virtual bool Propia { get; set; }
        public virtual int Progreso { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario usuario { get; set; }

    }
}
