﻿namespace Vic.SportsStore.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminUsersTbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUsers",
                c => new
                    {
                        AdminUserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminUsers");
        }
    }
}
