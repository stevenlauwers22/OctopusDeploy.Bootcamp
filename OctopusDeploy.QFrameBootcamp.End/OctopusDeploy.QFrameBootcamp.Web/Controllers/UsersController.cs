using System.Collections.Generic;
using System.Web.Mvc;
using OctopusDeploy.QFrameBootcamp.Web.Models;

namespace OctopusDeploy.QFrameBootcamp.Web.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            var users = GetUsers();
            return View(users);
        }

        private static IEnumerable<UserDTO> GetUsers()
        {
            using (var db = new PetaPoco.Database("BootcampConnectionString"))
            {
                var users = db.Query<UserDTO>("SELECT * FROM Users ORDER BY Firstname ASC, Lastname ASC");
                return users;
            }
        }
    }
}