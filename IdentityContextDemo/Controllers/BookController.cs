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

        //GET 
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("Home/Index")]
        public IActionResult Index()
        {

            return View();
        }


        [HttpGet]//LIST 
        [Route("Home/GetUserList")]
        [Route("Home/GetUserList/{id?}")]
         public async Task<IActionResult> GetUserList()
        {
            var data_ = await _bookRepository.GetUserDetails();
            return Json(new { data = data_ });
        }


        [HttpPost]//DELETE 
        [Route("Home/Delete")]
        [Route("Home/Delete/{id?}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _bookRepository.Delete(id);
            return Json(new { data = true });
        }


        [HttpGet]//EDIT 
        [Route("Home/Edit")]
        [Route("Home/Edit/{id?}")]
        public async Task<ActionResult> Edit(int id)
        {
            var data_ = await _bookRepository.GetEditDetail1(id);
            return Json(new { data = data_ });
        }


        [HttpPost]//EDIT
        [Route("Home/Edit")]
        [Route("Home/Edit/{id?}")]
        public async Task<ActionResult> Edit(UserDetail userDetail)
        {
            if (ModelState.IsValid)
            {
               await _bookRepository.GetEditDetail(userDetail);
            }
            return Json(new { data = true });
        }


        [HttpPost]//INSERT
        [Route("Home/Insert")]
        [Route("Home/Insert/{id?}")]
         public async Task<IActionResult> Insert(Add insert)
        {
            var result = await _bookRepository.InsertDetails(insert);
            return Json(result);
        }
    }
}
        