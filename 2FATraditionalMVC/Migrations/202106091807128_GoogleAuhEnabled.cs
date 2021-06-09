namespace _2FATraditionalMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoogleAuhEnabled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsGoogleAuthenticatorEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "GoogleAuthenticatorSecretKey", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "GoogleAuthenticatorSecretKey");
            DropColumn("dbo.AspNetUsers", "IsGoogleAuthenticatorEnabled");
        }
    }
}
