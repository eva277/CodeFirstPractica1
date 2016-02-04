using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using CodeFirstPractica1.Model;

namespace CodeFirstPractica1.DAL
{
    public class EmpresaContext:DbContext
    {
        public EmpresaContext():base("Empresa")
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Visita> Visitas { get; set; }
    }
}
