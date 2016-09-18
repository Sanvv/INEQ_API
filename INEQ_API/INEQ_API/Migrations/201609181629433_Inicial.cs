namespace INEQ_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Component",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        ComponentTypeID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                        EquipmentTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ComponentType", t => t.ComponentTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID, cascadeDelete: true)
                .ForeignKey("dbo.EquipmentType", t => t.EquipmentTypeID, cascadeDelete: true)
                .Index(t => t.ComponentTypeID)
                .Index(t => t.EquipmentID)
                .Index(t => t.EquipmentTypeID);
            
            CreateTable(
                "dbo.ComponentType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EntryDate = c.DateTime(nullable: false),
                        Serie = c.String(),
                        SofttekID = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        EquipmentTypeID = c.Int(nullable: false),
                        ModelID = c.Int(nullable: false),
                        BrandID = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        WarehouseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brand", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.EquipmentType", t => t.EquipmentTypeID, cascadeDelete: false)
                .ForeignKey("dbo.Model", t => t.ModelID, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusID, cascadeDelete: true)
                .ForeignKey("dbo.Warehouse", t => t.WarehouseID, cascadeDelete: true)
                .Index(t => t.EquipmentTypeID)
                .Index(t => t.ModelID)
                .Index(t => t.BrandID)
                .Index(t => t.StatusID)
                .Index(t => t.WarehouseID);
            
            CreateTable(
                "dbo.EquipmentType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        UserfulLife = c.Single(nullable: false),
                        GuaranteeDuration = c.Single(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Model",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                        BrandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brand", t => t.BrandID, cascadeDelete: false)
                .Index(t => t.BrandID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Warehouse",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        IS = c.String(),
                        Responsable = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Component", "EquipmentTypeID", "dbo.EquipmentType");
            DropForeignKey("dbo.Component", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.Equipment", "WarehouseID", "dbo.Warehouse");
            DropForeignKey("dbo.Equipment", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Equipment", "ModelID", "dbo.Model");
            DropForeignKey("dbo.Model", "BrandID", "dbo.Brand");
            DropForeignKey("dbo.Equipment", "EquipmentTypeID", "dbo.EquipmentType");
            DropForeignKey("dbo.Equipment", "BrandID", "dbo.Brand");
            DropForeignKey("dbo.Component", "ComponentTypeID", "dbo.ComponentType");
            DropIndex("dbo.Model", new[] { "BrandID" });
            DropIndex("dbo.Equipment", new[] { "WarehouseID" });
            DropIndex("dbo.Equipment", new[] { "StatusID" });
            DropIndex("dbo.Equipment", new[] { "BrandID" });
            DropIndex("dbo.Equipment", new[] { "ModelID" });
            DropIndex("dbo.Equipment", new[] { "EquipmentTypeID" });
            DropIndex("dbo.Component", new[] { "EquipmentTypeID" });
            DropIndex("dbo.Component", new[] { "EquipmentID" });
            DropIndex("dbo.Component", new[] { "ComponentTypeID" });
            DropTable("dbo.Warehouse");
            DropTable("dbo.Status");
            DropTable("dbo.Model");
            DropTable("dbo.EquipmentType");
            DropTable("dbo.Equipment");
            DropTable("dbo.ComponentType");
            DropTable("dbo.Component");
            DropTable("dbo.Brand");
        }
    }
}
