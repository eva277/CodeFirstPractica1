namespace CodeFirstPractica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asistencias",
                c => new
                    {
                        AsistenciaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        FechaIni = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraIni = c.DateTime(nullable: false),
                        HoraFin = c.DateTime(nullable: false),
                        ContactoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        EquipoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AsistenciaId)
                .ForeignKey("dbo.Contactoes", t => t.ContactoId, cascadeDelete: true)
                .ForeignKey("dbo.Equipoes", t => t.EquipoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.ContactoId)
                .Index(t => t.UsuarioId)
                .Index(t => t.EquipoId);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        ContactoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        Descripcion = c.String(),
                        CodPostal = c.Int(nullable: false),
                        Clase = c.String(),
                        TlfnCentralita = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Equipoes",
                c => new
                    {
                        EquipoId = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        Descripcion = c.String(),
                        Contrato = c.String(),
                        CondEspecial = c.String(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Visitas",
                c => new
                    {
                        VisitaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        FechaEfecto = c.DateTime(nullable: false),
                        HoraEfecto = c.DateTime(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        ContactoId = c.Int(nullable: false),
                        EquipoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaId)
                .ForeignKey("dbo.Contactoes", t => t.ContactoId, cascadeDelete: true)
                .ForeignKey("dbo.Equipoes", t => t.EquipoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.ContactoId)
                .Index(t => t.EquipoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Password = c.String(),
                        NumTecnico = c.Int(nullable: false),
                        Tipo = c.String(),
                        Correo = c.String(),
                        Ventanas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Tareas",
                c => new
                    {
                        TareasId = c.Int(nullable: false, identity: true),
                        HoraIni = c.DateTime(nullable: false),
                        FechaIni = c.DateTime(nullable: false),
                        Prioridad = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Concluido = c.Boolean(nullable: false),
                        Propia = c.Boolean(nullable: false),
                        Progreso = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TareasId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Incidencias",
                c => new
                    {
                        IncidenciaId = c.Int(nullable: false, identity: true),
                        FechaIni = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraIni = c.DateTime(nullable: false),
                        HoraFin = c.DateTime(nullable: false),
                        Concluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IncidenciaId);
            
            CreateTable(
                "dbo.IncidenciaAsistencias",
                c => new
                    {
                        Incidencia_IncidenciaId = c.Int(nullable: false),
                        Asistencia_AsistenciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Incidencia_IncidenciaId, t.Asistencia_AsistenciaId })
                .ForeignKey("dbo.Incidencias", t => t.Incidencia_IncidenciaId, cascadeDelete: true)
                .ForeignKey("dbo.Asistencias", t => t.Asistencia_AsistenciaId, cascadeDelete: true)
                .Index(t => t.Incidencia_IncidenciaId)
                .Index(t => t.Asistencia_AsistenciaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IncidenciaAsistencias", "Asistencia_AsistenciaId", "dbo.Asistencias");
            DropForeignKey("dbo.IncidenciaAsistencias", "Incidencia_IncidenciaId", "dbo.Incidencias");
            DropForeignKey("dbo.Visitas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Tareas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Asistencias", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Visitas", "EquipoId", "dbo.Equipoes");
            DropForeignKey("dbo.Visitas", "ContactoId", "dbo.Contactoes");
            DropForeignKey("dbo.Equipoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Asistencias", "EquipoId", "dbo.Equipoes");
            DropForeignKey("dbo.Contactoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Asistencias", "ContactoId", "dbo.Contactoes");
            DropIndex("dbo.IncidenciaAsistencias", new[] { "Asistencia_AsistenciaId" });
            DropIndex("dbo.IncidenciaAsistencias", new[] { "Incidencia_IncidenciaId" });
            DropIndex("dbo.Tareas", new[] { "UsuarioId" });
            DropIndex("dbo.Visitas", new[] { "EquipoId" });
            DropIndex("dbo.Visitas", new[] { "ContactoId" });
            DropIndex("dbo.Visitas", new[] { "UsuarioId" });
            DropIndex("dbo.Equipoes", new[] { "ClienteId" });
            DropIndex("dbo.Contactoes", new[] { "ClienteId" });
            DropIndex("dbo.Asistencias", new[] { "EquipoId" });
            DropIndex("dbo.Asistencias", new[] { "UsuarioId" });
            DropIndex("dbo.Asistencias", new[] { "ContactoId" });
            DropTable("dbo.IncidenciaAsistencias");
            DropTable("dbo.Incidencias");
            DropTable("dbo.Tareas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Visitas");
            DropTable("dbo.Equipoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Asistencias");
        }
    }
}
