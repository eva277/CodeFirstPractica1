namespace CodeFirstPractica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Password", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Usuarios", "Tipo", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Correo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Correo", c => c.String());
            AlterColumn("dbo.Usuarios", "Tipo", c => c.String());
            AlterColumn("dbo.Usuarios", "Password", c => c.String());
            AlterColumn("dbo.Usuarios", "Nombre", c => c.String());
        }
    }
}
