using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using CodeFirstPractica1.DAL;

namespace CodeFirstPractica1.Model
{
    [PropertyChanged.ImplementPropertyChanged]

    public class Usuario : PropertyValidateModel
    {   
        public Usuario()
        {
            Asistencias = new Collection<Asistencia>();
            Tareas = new Collection<Tareas>();
            Visitas = new Collection<Visita>();

        }

        public virtual int UsuarioId { get; set; }
        [Required]
        public virtual string Nombre { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 6)]

        public virtual string Password { get; set; }
        [Required]

        public virtual int NumTecnico { get; set; }
        [Required]
        public virtual string Tipo { get; set; }
        [Required(ErrorMessage = "Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public virtual string Correo { get; set; }
        public virtual int Ventanas { get; set; }
        public virtual ICollection<Tareas> Tareas { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }

        public virtual ICollection<Asistencia> Asistencias { get; set; }

    }
}
