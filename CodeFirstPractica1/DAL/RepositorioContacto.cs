using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class RepositorioContacto:RepositorioGenerico<Contacto>
    {
        public RepositorioContacto(EmpresaContext context) : base(context)
        {
        }
        public Contacto geContactoConAsistencias(int idContacto)
        {
            return dbSet.Include("Asistencias").Where(c => c.ContactoId == idContacto).FirstOrDefault();
        }
        public IEnumerable<Contacto> GetFiltrado(String buscado)
        {
            if (!string.IsNullOrWhiteSpace(buscado))
            {
                return Get(filter: (usuario => usuario.Nombre.ToUpper().Contains(buscado.ToUpper())
                                            || usuario.Email.ToUpper().Contains(buscado.ToUpper())
                                            || usuario.Telefono.ToUpper().Contains(buscado.ToUpper())
                                            ));
            }
            else return Get();
        }
        public IEnumerable<Contacto> GetFiltradoAlfabeticamente(String buscado)
        {
            if (!string.IsNullOrWhiteSpace(buscado))
            {
                return Get(filter: (usuario => usuario.Nombre.ToUpper().Contains(buscado.ToUpper())
                                            || usuario.Email.ToUpper().Contains(buscado.ToUpper())),

                            orderBy: clientes => clientes.OrderBy(
                                m => new {m.Nombre }));
            }
            else
                return Get(orderBy: clientes => clientes.OrderBy
               (m => new { m.Nombre }));
        }
        public virtual void Delete(int idContacto)
        {

            Contacto contacto = context.Contactos.Include("Asistencia").Where(c => c.ContactoId == idContacto).Single();
            
            Delete(contacto);
        }
    }
}
