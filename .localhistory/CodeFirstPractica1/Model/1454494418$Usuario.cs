using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Usuario
    {   
        public Usuario()
        {

        }

        public virtual int UsuarioId { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Password { get; set; }
        public virtual int NumTecnico { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Correo { get; set; }
        public virtual int Ventanas { get; set; }
        public ICollection<Tareas> Tareas { get; set; }
        public ICollection<Visita> Visita { get; set; }

        public ICollection<Asistencia> Asistencia { get; set; }

    }
}
