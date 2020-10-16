using DemoDTO.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoRepository.Implementation
{
    public interface IBookRepository
    {
        Task<List<UserDetail>> GetUserDetails();
       // Task<int> AddNewBook(UserDetail insert);
        //int AddNewBook(UserDetail model);
        //List<UserDetail> GetAllBooks();
       // UserDetail GetBookById(int id);
        //List<UserDetail> SearchBook(string title, string authorName);
    }
}