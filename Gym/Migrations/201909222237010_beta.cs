namespace Gym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class beta : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TraineeSubscriptionsDetails", "TraineeSubscription_Id", "dbo.TraineeSubscriptions");
            DropIndex("dbo.TraineeSubscriptionsDetails", new[] { "TraineeSubscription_Id" });
            RenameColumn(table: "dbo.TraineeSubscriptionsDetails", name: "TraineeSubscription_Id", newName: "TraineeSubscriptionId");
            AlterColumn("dbo.TraineeSubscriptionsDetails", "TraineeSubscriptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.TraineeSubscriptionsDetails", "TraineeSubscriptionId");
            AddForeignKey("dbo.TraineeSubscriptionsDetails", "TraineeSubscriptionId", "dbo.TraineeSubscriptions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TraineeSubscriptionsDetails", "TraineeSubscriptionId", "dbo.TraineeSubscriptions");
            DropIndex("dbo.TraineeSubscriptionsDetails", new[] { "TraineeSubscriptionId" });
            AlterColumn("dbo.TraineeSubscriptionsDetails", "TraineeSubscriptionId", c => c.Int());
            RenameColumn(table: "dbo.TraineeSubscriptionsDetails", name: "TraineeSubscriptionId", newName: "TraineeSubscription_Id");
            CreateIndex("dbo.TraineeSubscriptionsDetails", "TraineeSubscription_Id");
            AddForeignKey("dbo.TraineeSubscriptionsDetails", "TraineeSubscription_Id", "dbo.TraineeSubscriptions", "Id");
        }
    }
}
