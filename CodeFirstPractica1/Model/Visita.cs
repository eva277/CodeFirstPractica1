using CodeFirstPractica1.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    [PropertyChanged.ImplementPropertyChanged]

    public class Visita : PropertyValidateModel
    {
        public Visita()
        {
            Equipos = new Collection<Equipo>();
        }

        public int VisitaId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEfecto { get; set; }
        public DateTime HoraEfecto { get; set; }
        public Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Contacto Contacto { get; set; }
        public virtual int ContactoId { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }

    }
}
