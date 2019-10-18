using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingValidation.Repositories;
using ModelBindingValidation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelBindingValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;      // DI. like _context passing to the controller
        public HomeController(IRepository repo)
        {
            repository = repo;       // passes the repository context to the controller
        }     
        // GET: /<controller>/
      
        public ViewResult Index(int id)
        {
            
            return View(repository[id]);
            
        }
    }
}
