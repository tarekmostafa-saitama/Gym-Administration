namespace Gym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TraineeSubscriptions", "SubscriptionEndTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TraineeSubscriptions", "SubscriptionEndTime");
        }
    }
}
