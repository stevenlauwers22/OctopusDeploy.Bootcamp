using FluentMigrator;

namespace OctopusDeploy.QFrameBootcamp.DB
{
    [Migration(001)]
    public class M001_Create_Table_Users : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                  .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
                  .WithColumn("Firstname").AsString().NotNullable()
                  .WithColumn("Lastname").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Users");
        }
    }
}