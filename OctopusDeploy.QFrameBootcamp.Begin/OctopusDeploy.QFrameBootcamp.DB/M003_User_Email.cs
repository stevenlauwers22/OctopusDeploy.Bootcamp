using FluentMigrator;

namespace OctopusDeploy.QFrameBootcamp.DB
{
    [Migration(003)]
    public class M003_User_Email : Migration
    {
        public override void Up()
        {
            Create
                .Column("Email")
                .OnTable("Users")
                .AsString(75)
                .Nullable();

            Execute.Sql("UPDATE Users SET Email = FirstName + '.' + LastName + '@qframe.be'");
        }

        public override void Down()
        {
            Delete.Column("Email")
                  .FromTable("Users");
        }
    }
}