namespace UserManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingposition : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tb_M_Employee", "Position_Id", "dbo.Tb_M_Position");
            DropIndex("dbo.Tb_M_Employee", new[] { "Position_Id" });
            AlterColumn("dbo.Tb_M_Employee", "Position_Id", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tb_M_Employee", "Position_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tb_M_Employee", "Position_Id");
            AddForeignKey("dbo.Tb_M_Employee", "Position_Id", "dbo.Tb_M_Position", "Id");
        }
    }
}
