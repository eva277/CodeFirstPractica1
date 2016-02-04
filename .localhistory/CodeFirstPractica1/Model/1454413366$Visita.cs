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
    }
}
