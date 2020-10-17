using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoRepository.Interface;
using DemoDTO.Models;
using DemoRepository.Implementation;
using static DemoDTO.Models.UserDetail;


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
        public async Task<IActionResult> GetUserList()
        {
            var data_ = await _bookRepository.GetUserDetails();
            return Json(new { data = data_ });
        }
        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            await _bookRepository.Delete(id);
            return Json(new { data = true });
        }
        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            var data_ = await _bookRepository.GetEditDetail1(id);
            return Json(new { data = data_ });
        }
        [HttpPost]
        public async Task<ActionResult> Edit(UserDetail userDetail)
        {
            if (ModelState.IsValid)
            {
               await _bookRepository.GetEditDetail(userDetail);
            }
            return Json(new { data = true });
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Add insert)
        {
            var result = await _bookRepository.InsertDetails(insert);
            return Json(result);
        }
    }
}
        