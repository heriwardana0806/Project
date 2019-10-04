namespace UserManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tb_M_Employee", "Birth_Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tb_M_Employee", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tb_M_Employee", "Birth_Place", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tb_M_Employee", "Birth_Place");
            DropColumn("dbo.Tb_M_Employee", "IsActive");
            DropColumn("dbo.Tb_M_Employee", "Birth_Date");
        }
    }
}
