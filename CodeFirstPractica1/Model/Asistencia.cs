using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.DAL;


namespace CodeFirstPractica1.Model
{
    [PropertyChanged.ImplementPropertyChanged]

    public class Asistencia : PropertyValidateModel
    {
        public Asistencia()
        {
            Incidencias = new Collection<Incidencia>();

        }

        public int AsistenciaId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraIni { get; set; }
        public DateTime HoraFin { get; set; }
        public virtual Contacto Contacto { get; set; }
        public virtual int ContactoId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Equipo Equipo { get; set; }
        public virtual int EquipoId { get; set; }
        public virtual ICollection<Incidencia> Incidencias { get; set; }
    }
}
