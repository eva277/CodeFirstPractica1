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
            Tareass = new Collection<Tareas>();
            Visitas = new Collection<Visita>();

        }

        public virtual int UsuarioId { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Password { get; set; }
        public virtual int NumTecnico { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Correo { get; set; }
        public virtual int Ventanas { get; set; }
        public ICollection<Tareas> Tareass { get; set; }
        public ICollection<Visita> Visitas { get; set; }

        public ICollection<Asistencia> Asistencias { get; set; }

    }
}
