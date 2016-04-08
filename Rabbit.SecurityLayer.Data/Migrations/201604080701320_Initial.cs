namespace Rabbit.SecurityLayer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DisplayName = c.String(),
                        Email = c.String(),
                        ConfigurationFlags = c.Int(nullable: false),
                        Phone = c.String(),
                        Profile = c.String(),
                        LastModifiedAt = c.DateTime(),
                        LastModifiedBy = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        State = c.String(),
                        StateLastChangedAt = c.DateTime(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
