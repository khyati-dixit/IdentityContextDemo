using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoRepository.Interface;
using DemoDTO.Models;
using DemoRepository.Implementation;
//using System.Web.Mvc;
//using System.Web.Mvc;

namespace IdentityContextDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var data_ = await _bookRepository.GetUserDetails();
            return View(Json(new { data = data_ } ));
        }
        //[HttpPost]
        //public async Task<ActionResult> Edit(UserDetail insert)
        //{
        //   // var data_ = await _bookRepository.GetEditDetail1(insert);
        //    return View(Json(new { data = true });
        //}
        //[HttpGet]
        //public async Task<ActionResult> Edit(int id)
        //{
        // //   var result = await _bookRepository.GetEditDetail(id);
        //    return Json(new { data = true });//Json(new { UserId = result.UserId, FullName = result.FullName, UserEmail = result.UserEmail, CivilIdNumber = result.CivilIdNumber, CarLicense = result.CarDetails }, JsonRequestBehavior.AllowGet);
        //}
        //[Route("book-details/{id}", Name = "bookDetailsRoute")]
        //public UserDetail GetBook(int id)
        //{
        //    return _bookRepository.GetBookById(id);

        //}
    }
}
//        public List<UserDetail> SearchBooks(string bookName, string authorName)
//        {
//            return _bookRepository.SearchBook(bookName, authorName);
//        }
//        public ViewResult AddNewBook(bool IsSuccess = false, int bookId = 0)
//        {
//            ViewBag.IsSuccess = IsSuccess;
//            return View();
//        }
//        [HttpPost]//
//        public IActionResult AddNewBook(UserDetail userDetail)
//        {
//            int id =  _bookRepository.AddNewBook(userDetail);
//            if (id > 0)
//            {
//                _bookRepository.AddNewBook(userDetail);
//                return RedirectToAction(nameof(AddNewBook), new { IsSuccess = true, bookId = id});
                
//            }
//            return View();
//        }
//    }
//}
