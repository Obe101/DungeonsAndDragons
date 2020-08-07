namespace DungeonsAndDragons.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharInfoes",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        CharacterName = c.String(),
                        Class = c.String(),
                        Level = c.Int(nullable: false),
                        Race = c.String(),
                        Background = c.String(),
                        Alignment = c.String(),
                    })
                .PrimaryKey(t => t.CharacterId);
            
            CreateTable(
                "dbo.CharStats",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        Strength = c.Int(nullable: false),
                        Dexterity = c.Int(nullable: false),
                        Constitution = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        Wisdom = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CharStats");
            DropTable("dbo.CharInfoes");
        }
    }
}
