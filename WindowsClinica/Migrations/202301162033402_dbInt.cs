namespace WindowsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Habitaciones");
            DropTable("dbo.Clinicas");
        }
    }
}
