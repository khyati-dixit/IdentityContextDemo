using DemoEntity.Data;
using DemoDTO.Models;
using DemoRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoRepository.Implementation;
using DemoEntity.Model;
using DemoEntity.Interface;

namespace DemoRepository.Interface
{

    public class BookRepository : IBookRepository
    {
        private readonly IEntityUsers _entityUsers;
        public BookRepository(IEntityUsers entityUsers)
        {
            _entityUsers = entityUsers;
        }
        public async Task<List<UserDetail>> GetUserDetails()
        {
            var userListDTO = new List<UserDetail>();
            var carDetails = new List<CarDetails>();
            var usersList = await _entityUsers.GetUserDetails();


            userListDTO.AddRange(
            usersList.Select(x => new UserDetail
            {
                UserId = x.UserId,
                FullName = x.FullName,
                UserEmail = x.UserEmail
            }).ToList());

            //var cardetails = string.Join(",", carDetails.Where(x => x.UserId == ).Select(y => y.CarLicense).ToList());
            return userListDTO;

        }

        //public BookRepository(traffictraineesContext context)
        //{
        //    _context = context;
        //}

        //public int AddNewBook(UserDetail model)
        //{
        //    var newBook = new UserDetails()
        //    {
        //        FullName = model.FullName,
        //        UserEmail = model.UserEmail,
        //        CivilIdNumber = model.CivilIdNumber,
        //        //CarDetails = model.CarLicense
        //    };
        //    var car = new CarDetail()
        //    {
        //        CarLicense = insert.CarLicense,
        //        UserId = insert.UserId
        //    };
        //    _context.UserDetails.AddAsync(newBook);
        //    _context.SaveChangesAsync();
        //    return newBook.UserId;
        //}

        //public List<UserDetail> GetAllBooks()
        //{
        //    return DataSource();
        //}
        //public UserDetail GetBookById(int id)
        //{
        //    return DataSource().Where(x => x.UserId == id).FirstOrDefault();
        //}
        //public List<UserDetail> SearchBook(string title, string authorName)
        //{
        //    return null;//DataSource().Where(x => x.BookName.Contains(title) || x.AuthorName.Contains(authorName)).ToList();
        //}

        //int IBookRepository.AddNewBook(UserDetail model)
        //{
        //    throw new NotImplementedException();
        //}

        //private List<UserDetail> DataSource()
        //{
        //    return new List<UserDetail>()
        //        {

        //            //new UserDetail(){ Id= 1,BookName="mVC",AuthorName="Neha Sharma"},
        //            //new UserDetail(){ Id= 2,BookName="mVC",AuthorName="Neha Sharma"},
        //            //new UserDetail(){ Id= 3,BookName="mVC",AuthorName="Neha Sharma"},

        //        };
        //}

        //Task<int> IBookRepository.AddNewBook(UserDetail insert)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<BookModel>> GetAllBooks()
        //{
        //    var books = new List<BookModel>();
        //    var allbooks = await _context.Books.ToArrayAsync();
        //    foreach (var book in allbooks)
        //    {
        //        books.Add(new BookModel()
        //        {
        //            Id = book.Id,
        //            AuthorName = book.AuthorName,
        //            BookName = book.BookName
        //        });

        //    }
        //    return books;
        //}

    }

}
