namespace CodeFirstPractica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Visitas", "EquipoId", "dbo.Equipoes");
            DropIndex("dbo.Visitas", new[] { "EquipoId" });
            CreateTable(
                "dbo.VisitaEquipoes",
                c => new
                    {
                        Visita_VisitaId = c.Int(nullable: false),
                        Equipo_EquipoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Visita_VisitaId, t.Equipo_EquipoId })
                .ForeignKey("dbo.Visitas", t => t.Visita_VisitaId, cascadeDelete: true)
                .ForeignKey("dbo.Equipoes", t => t.Equipo_EquipoId, cascadeDelete: false)
                .Index(t => t.Visita_VisitaId)
                .Index(t => t.Equipo_EquipoId);
            
            DropColumn("dbo.Visitas", "EquipoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Visitas", "EquipoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.VisitaEquipoes", "Equipo_EquipoId", "dbo.Equipoes");
            DropForeignKey("dbo.VisitaEquipoes", "Visita_VisitaId", "dbo.Visitas");
            DropIndex("dbo.VisitaEquipoes", new[] { "Equipo_EquipoId" });
            DropIndex("dbo.VisitaEquipoes", new[] { "Visita_VisitaId" });
            DropTable("dbo.VisitaEquipoes");
            CreateIndex("dbo.Visitas", "EquipoId");
            AddForeignKey("dbo.Visitas", "EquipoId", "dbo.Equipoes", "EquipoId", cascadeDelete: true);
        }
    }
}
