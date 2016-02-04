namespace CodeFirstPractica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contactoes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Contactoes", "Telefono", c => c.String(maxLength: 12));
            AlterColumn("dbo.Contactoes", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contactoes", "Email", c => c.String());
            AlterColumn("dbo.Contactoes", "Telefono", c => c.String());
            AlterColumn("dbo.Contactoes", "Nombre", c => c.String());
        }
    }
}
