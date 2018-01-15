namespace POSData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class POS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nmae = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Image = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryType = c.String(),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        categoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.categoryID, cascadeDelete: true)
                .Index(t => t.categoryID);
            
            CreateTable(
                "dbo.ExpenseItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        expenseCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExpenseCategories", t => t.expenseCategoryID, cascadeDelete: true)
                .Index(t => t.expenseCategoryID);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Image = c.Byte(nullable: false),
                        CategoryType = c.String(),
                        categoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.categoryID, cascadeDelete: true)
                .Index(t => t.categoryID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        CostPrice = c.Double(nullable: false),
                        SalePrice = c.Double(nullable: false),
                        Code = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Image = c.Byte(nullable: false),
                        itemCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ItemCategories", t => t.itemCategoryID, cascadeDelete: true)
                .Index(t => t.itemCategoryID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(),
                        Email = c.String(nullable: false),
                        Outlet = c.String(nullable: false),
                        JoiningDate = c.DateTime(nullable: false),
                        ContactNo = c.String(nullable: false),
                        Reference = c.String(nullable: false),
                        EmargencyContactNo = c.String(nullable: false),
                        NID = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        MotherName = c.String(nullable: false),
                        PresentAddress = c.String(nullable: false),
                        PermanentAddress = c.String(nullable: false),
                        Image = c.Byte(nullable: false),
                        outletID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Outlets", t => t.outletID, cascadeDelete: true)
                .Index(t => t.outletID);
            
            CreateTable(
                "dbo.Outlets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        ContactNo = c.String(),
                        Address = c.String(),
                        organizationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Organizations", t => t.organizationID, cascadeDelete: true)
                .Index(t => t.organizationID);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Contact = c.String(),
                        Image = c.Byte(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Parties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        PartyType = c.String(),
                        Image = c.Byte(nullable: false),
                        organizationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Organizations", t => t.organizationID, cascadeDelete: true)
                .Index(t => t.organizationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parties", "organizationID", "dbo.Organizations");
            DropForeignKey("dbo.Outlets", "organizationID", "dbo.Organizations");
            DropForeignKey("dbo.Employees", "outletID", "dbo.Outlets");
            DropForeignKey("dbo.Items", "itemCategoryID", "dbo.ItemCategories");
            DropForeignKey("dbo.ItemCategories", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.ExpenseItems", "expenseCategoryID", "dbo.ExpenseCategories");
            DropForeignKey("dbo.ExpenseCategories", "categoryID", "dbo.Categories");
            DropIndex("dbo.Parties", new[] { "organizationID" });
            DropIndex("dbo.Outlets", new[] { "organizationID" });
            DropIndex("dbo.Employees", new[] { "outletID" });
            DropIndex("dbo.Items", new[] { "itemCategoryID" });
            DropIndex("dbo.ItemCategories", new[] { "categoryID" });
            DropIndex("dbo.ExpenseItems", new[] { "expenseCategoryID" });
            DropIndex("dbo.ExpenseCategories", new[] { "categoryID" });
            DropTable("dbo.Parties");
            DropTable("dbo.Organizations");
            DropTable("dbo.Outlets");
            DropTable("dbo.Employees");
            DropTable("dbo.Items");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.ExpenseItems");
            DropTable("dbo.ExpenseCategories");
            DropTable("dbo.Categories");
        }
    }
}
