using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_1.Models;

namespace Project_1.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult AddOrEdit(int id=0)
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
            using (DbModels dbModel = new DbModels())
            {
                dbModel.Users.Add(userModel);
            }
        }

    }
}
