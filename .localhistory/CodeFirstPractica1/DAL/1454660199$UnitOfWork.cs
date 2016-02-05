using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPractica1.DAL
{
    class UnitOfWork : IDisposable
    {
        private EmpresaContext context = new EmpresaContext();
        private bool disposed = false;

        private RepositorioAsistencia repositorioAsistencia;
        private RepositorioCliente repositorioCliente;
        private RepositorioConexion repositorioConexion;
        private RepositorioContacto repositorioContacto;
        private RepositorioEquipo repositorioEquipo;
        private RepositorioIncidencia repositorioIncidencia;
        private RepositorioTarea repositorioTarea;
        private RepositorioUsuario repositorioUsuario;
        private RepositorioVisita repositorioVisita;

        public RepositorioAsistencia RepositorioAsistencia
        {
            get
            {
                if (this.repositorioAsistencia == null)
                {
                    this.repositorioAsistencia =
                        new RepositorioAsistencia(context);
                }

                return repositorioAsistencia;
            }
        }
        public RepositorioCliente RepositorioCliente
        {
            get
            {
                if (this.repositorioCliente == null)
                {
                    this.repositorioCliente =
                        new RepositorioCliente(context);
                }

                return repositorioCliente;
            }
        }
        public RepositorioConexion RepositorioConexion
        {
            get
            {
                if (this.repositorioConexion == null)
                {
                    this.repositorioConexion =
                        new RepositorioConexion(context);
                }

                return repositorioConexion;
            }
        }
        public RepositorioContacto RepositorioContacto
        {
            get
            {
                if (this.repositorioContacto == null)
                {
                    this.repositorioContacto =
                        new RepositorioContacto(context);
                }

                return repositorioContacto;
            }
        }
        public RepositorioEquipo RepositorioEquipo
        {
            get
            {
                if (this.repositorioEquipo == null)
                {
                    this.repositorioEquipo =
                        new RepositorioEquipo(context);
                }

                return repositorioEquipo;
            }
        }
        public RepositorioIncidencia RepositorioIncidencia
        {
            get
            {
                if (this.repositorioIncidencia == null)
                {
                    this.repositorioIncidencia =
                        new RepositorioIncidencia(context);
                }

                return repositorioIncidencia;
            }
        }
        public RepositorioTarea RepositorioTarea
        {
            get
            {
                if (this.repositorioTarea == null)
                {
                    this.repositorioTarea =
                        new RepositorioTarea(context);
                }

                return repositorioTarea;
            }
        }
        public RepositorioUsuario RepositorioUsuario
        {
            get
            {
                if (this.repositorioTarea == null)
                {
                    this.repositorioTarea =
                        new RepositorioUsuario(context);
                }

                return repositorioTarea;
            }
        }
        public RepositorioVisita RepositorioVisita
        {
            get
            {
                if (this.repositorioVisita == null)
                {
                    this.repositorioVisita =
                        new RepositorioVisita(context);
                }

                return repositorioVisita;
            }
        }
        
        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
