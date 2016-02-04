using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.Model
{
    public class Contacto
    {
        public Contacto()
        {

        }

        public virtual int ContactoId { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Email { get; set; }

    }
}
