namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedATable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OkToDelete",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SomeColumn = c.String(),
                        SomeName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OkToDelete");
        }
    }
}
