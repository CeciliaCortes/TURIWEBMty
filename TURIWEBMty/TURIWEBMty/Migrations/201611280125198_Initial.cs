namespace TURIWEBMty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Hora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transporte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Transportee = c.String(),
                        IdHorario = c.DateTime(nullable: false),
                        Horarios_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Horario", t => t.Horarios_ID)
                .Index(t => t.Horarios_ID);
            
            CreateTable(
                "dbo.Lugar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoLugar = c.String(),
                        IdMunicipio = c.Int(nullable: false),
                        IdTransporte = c.Int(nullable: false),
                        IdUbicacion = c.Int(nullable: false),
                        Municipios_Id = c.Int(),
                        Transportes_Id = c.Int(),
                        Ubicaciones_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipio", t => t.Municipios_Id)
                .ForeignKey("dbo.Transporte", t => t.Transportes_Id)
                .ForeignKey("dbo.Ubicacion", t => t.Ubicaciones_Id)
                .Index(t => t.Municipios_Id)
                .Index(t => t.Transportes_Id)
                .Index(t => t.Ubicaciones_Id);
            
            CreateTable(
                "dbo.Municipio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Municipios = c.String(),
                        Poblacion = c.Int(nullable: false),
                        Superficie = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ubicacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdMunicipio = c.Int(nullable: false),
                        Municipios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipio", t => t.Municipios_Id)
                .Index(t => t.Municipios_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ubicacion", "Municipios_Id", "dbo.Municipio");
            DropForeignKey("dbo.Lugar", "Ubicaciones_Id", "dbo.Ubicacion");
            DropForeignKey("dbo.Lugar", "Transportes_Id", "dbo.Transporte");
            DropForeignKey("dbo.Lugar", "Municipios_Id", "dbo.Municipio");
            DropForeignKey("dbo.Transporte", "Horarios_ID", "dbo.Horario");
            DropIndex("dbo.Ubicacion", new[] { "Municipios_Id" });
            DropIndex("dbo.Lugar", new[] { "Ubicaciones_Id" });
            DropIndex("dbo.Lugar", new[] { "Transportes_Id" });
            DropIndex("dbo.Lugar", new[] { "Municipios_Id" });
            DropIndex("dbo.Transporte", new[] { "Horarios_ID" });
            DropTable("dbo.Ubicacion");
            DropTable("dbo.Municipio");
            DropTable("dbo.Lugar");
            DropTable("dbo.Transporte");
            DropTable("dbo.Horario");
        }
    }
}
