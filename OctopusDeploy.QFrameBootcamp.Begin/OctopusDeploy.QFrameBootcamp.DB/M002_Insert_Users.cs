using System;
using FluentMigrator;

namespace OctopusDeploy.QFrameBootcamp.DB
{
    [Migration(002)]
    public class M002_Insert_Users : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Users")
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Hans", Lastname = "Boeren"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Luc", Lastname = "Bos"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Tom", Lastname = "Ceuppens"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Ken", Lastname = "De Meyer"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Frederik", Lastname = "Delbroek"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Steven", Lastname = "Detré"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Sander", Lastname = "Falleyn"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Niels", Lastname = "Festjens"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Danny", Lastname = "Gladines"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Koen", Lastname = "Hoefkens"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Tom", Lastname = "Knapen"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Gino", Lastname = "Lambregts"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Steven", Lastname = "Lauwers"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Petra", Lastname = "Liesmons"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Ian", Lastname = "Luyten"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Johan", Lastname = "Meeusen"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Koert", Lastname = "Moreau"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Nico", Lastname = "Saey"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Kris", Lastname = "Senden"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Bart", Lastname = "Van Boeckhout"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Guy", Lastname = "Van den Nieuwenhof"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Kevin", Lastname = "Van Den Sande"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Thijs", Lastname = "Van Der Schraelen"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "David", Lastname = "Van Vlasselaer"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Johan", Lastname = "Ven"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Karina", Lastname = "Vereecken"})
                  .Row(new {Id = Guid.NewGuid(), Firstname = "Gitte", Lastname = "Vermeiren"});
        }

        public override void Down()
        {
            Delete.FromTable("Users")
                  .AllRows();
        }
    }
}