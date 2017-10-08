using Library.Entities;
using Library.UnitOfWork;
using Library.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.WebApp.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            //List<BookVM> books = LibraryUnit.BookRepository.AllItems.Select(
            //    x => new BookVM
            //    {
            //        Name = x.Name,
            //        Theme = x.Theme.Name,
            //        Authors=x.Authors.Select(a=> a.FirstName + " " + a.LastName),
            //        Category=x.Category.Name,
            //        Press=x.Press.Name,
            //        Quantity=x.Quantity
            //    }
            //).ToList();
            return View("Index", LibraryUnit.BookRepository.AllItems.ToList());
        }

        [HttpPost]
        public ActionResult Index(BookVM book)
        {

            return View("Index", LibraryUnit.BookRepository.AllItems.ToList());
        }
    }
}