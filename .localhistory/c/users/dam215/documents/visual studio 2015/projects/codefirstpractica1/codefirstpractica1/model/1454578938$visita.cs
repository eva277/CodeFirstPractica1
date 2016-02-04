using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Visita
    {
        public Visita()
        {

        }

        public virtual int VisitaId { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual DateTime FechaEfecto { get; set; }
        public virtual DateTime HoraEfecto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Contacto Contacto { get; set; }
        public virtual int ContactoId { get; set; }
        public virtual Equipo Equipo { get; set; }
        public virtual int EquipoId { get; set; }

    }
}
