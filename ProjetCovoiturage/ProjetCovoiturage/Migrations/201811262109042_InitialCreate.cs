namespace ProjetCovoiturage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chauffeurs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Prenom = c.String(),
                        Nom = c.String(),
                        NumeroPermis = c.String(),
                        NumeroTelephone = c.Int(nullable: false),
                        Ville = c.String(),
                        DatePermis = c.DateTime(nullable: false),
                        DateEmbauche = c.DateTime(nullable: false),
                        VehiculeModel = c.String(),
                        DateEnRoute = c.DateTime(nullable: false),
                        NbPlace = c.Int(nullable: false),
                        voitureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voitures",
                c => new
                    {
                        VoitureID = c.Int(nullable: false, identity: true),
                        ModeleVoiture = c.String(),
                        dateMiseRoute = c.DateTime(nullable: false),
                        nbPlace = c.Int(nullable: false),
                        chauffeurID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VoitureID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VoitureChauffeurs",
                c => new
                    {
                        Voiture_VoitureID = c.Int(nullable: false),
                        Chauffeur_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Voiture_VoitureID, t.Chauffeur_Id })
                .ForeignKey("dbo.Voitures", t => t.Voiture_VoitureID, cascadeDelete: true)
                .ForeignKey("dbo.Chauffeurs", t => t.Chauffeur_Id, cascadeDelete: true)
                .Index(t => t.Voiture_VoitureID)
                .Index(t => t.Chauffeur_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.VoitureChauffeurs", "Chauffeur_Id", "dbo.Chauffeurs");
            DropForeignKey("dbo.VoitureChauffeurs", "Voiture_VoitureID", "dbo.Voitures");
            DropIndex("dbo.VoitureChauffeurs", new[] { "Chauffeur_Id" });
            DropIndex("dbo.VoitureChauffeurs", new[] { "Voiture_VoitureID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.VoitureChauffeurs");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Voitures");
            DropTable("dbo.Chauffeurs");
        }
    }
}
