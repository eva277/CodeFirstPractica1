namespace CodeFirstPractica1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Apellidos", c => c.String());
            AlterColumn("dbo.Clientes", "Nombre", c => c.String());
        }
    }
}
