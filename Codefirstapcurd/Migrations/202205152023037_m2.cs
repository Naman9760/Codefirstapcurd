namespace Codefirstapcurd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Eid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Mob = c.String(),
                        salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employes");
        }
    }
}
