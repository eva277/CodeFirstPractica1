using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class RepositorioCliente:RepositorioGenerico<Cliente>
    {
        public RepositorioCliente(EmpresaContext context) : base(context)
        {

        }
        public Cliente geClienteConContacto(int idCliente)
        {
            return dbSet.Include("Contactos").Where(c => c.ClienteId == idCliente).FirstOrDefault();
        }
        public IEnumerable<Cliente> GetFiltrado(String buscado)
        {
            if (!string.IsNullOrWhiteSpace(buscado))
            {
                return Get(filter: (usuario => usuario.Nombre.ToUpper().Contains(buscado.ToUpper())));
            }
            else return Get();
        }
        public IEnumerable<Cliente> GetFiltradoAlfabeticamente(String buscado)
        {
            if (!string.IsNullOrWhiteSpace(buscado))
            {
                return Get(filter: (usuario => usuario.Nombre.ToUpper().Contains(buscado.ToUpper())),
                            orderBy: clientes => clientes.OrderBy( m => new { m.Nombre }));
            }
            else
                return Get(orderBy: clientes => clientes.OrderBy
               (m => new { m.Nombre }));
        }
        public virtual void Delete(int idCliente)
        {
            Cliente cliente = context.Clientes.Include("Contacto").Where(c => c.ClienteId == idCliente).Single();

            Delete(cliente);
        }
    }
}
