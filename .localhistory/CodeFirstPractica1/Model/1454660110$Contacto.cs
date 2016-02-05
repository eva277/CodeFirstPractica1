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

    public class Contacto :: PropertyValidateModel
    {
        public Contacto()
        {
            Visitas = new Collection<Visita>();
            Asistencias = new Collection<Asistencia>();

        }

        public virtual int ContactoId { get; set; }
        [Required]

        public virtual string Nombre { get; set; }
        [StringLength(12, MinimumLength = 9)]
        [Phone]
        [DataType(DataType.PhoneNumber, ErrorMessage = "El numero de telefono no es valido")]
        public virtual string Telefono { get; set; }
        [Required(ErrorMessage = "Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public virtual string Email { get; set; }
        public virtual ICollection<Visita> Visitas { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }

    }
}
