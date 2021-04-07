using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalendarScopic.Web.Models;
using KalendarScopic.Web.BLL;

namespace KalendarScopic.Web.Controllers
{
    public class UserController : Controller
    {

        public IActionResult New()
        {
            var usr = new User();
            return View(usr);

        }

        [HttpPost]
        public IActionResult New(User usr) 
        {
            try 
            { 
                var bll = new UserBLL();
                bll.New(usr);
                return RedirectToAction("Index");
            }

            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(usr);
            }


        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
