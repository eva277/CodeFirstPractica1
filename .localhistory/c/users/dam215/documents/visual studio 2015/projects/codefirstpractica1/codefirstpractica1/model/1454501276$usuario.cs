using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace CodeFirstPractica1.Model
{
    public class Usuario
    {   
        public Usuario()
        {
            Asistencias = new Collection<Asistencia>();
            Tareas = new Collection<Tareas>();
            Visitas = new Collection<Visita>();

        }

        public virtual int UsuarioId { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Password { get; set; }
        public virtual int NumTecnico { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Correo { get; set; }
        public virtual int Ventanas { get; set; }
        public virtual ICollection<Tareas> Tareas { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }

        public virtual ICollection<Asistencia> Asistencias { get; set; }

    }
}
