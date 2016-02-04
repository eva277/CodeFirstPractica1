using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace CodeFirstPractica1.Model
{
    public class Contacto
    {
        public Contacto()
        {
            Visitas = new Collection<Visita>();
            Asistencias = new Collection<Asistencia>();

        }

        public virtual int ContactoId { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Email { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}
