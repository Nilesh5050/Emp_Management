using Emp_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UserLogin.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext dbContext;

        public UserController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;

        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            //var customers = dbContext.customers.ToList();
            var en = dbContext.AspNetUsers.ToList();
            return View(en);
        }

    }
}
