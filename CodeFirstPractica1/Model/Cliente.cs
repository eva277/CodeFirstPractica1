using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CodeFirstPractica1.DAL;


namespace CodeFirstPractica1.Model
{
    [PropertyChanged.ImplementPropertyChanged]

    public class Cliente : PropertyValidateModel
{
        public Cliente()
        {
            Contactos = new Collection<Contacto>();
            Equipos = new Collection<Equipo>();

        }

        public int ClienteId { get; set; }
        [Required]

        public string Nombre { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Apellidos { get; set; }
        [Display(Name = "Nombre Completo")]

        public string nombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }

        public string Descripcion { get; set; }

        public int CodPostal { get; set; }
        public string Clase { get; set; }
        public string TlfnCentralita { get; set; }
        public virtual ICollection<Contacto> Contactos {get;set;}
        public virtual ICollection<Equipo> Equipos { get; set; }

    }
}
