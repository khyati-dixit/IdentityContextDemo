using DemoDTO.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DemoDTO.Models.UserDetail;

namespace DemoRepository.Implementation
{
    public interface IBookRepository
    {
        Task<List<UserDetail>> GetUserDetails();
        Task<bool> Delete(int id);
        Task<UserDetail> GetEditDetail1(int id);
        Task<bool> InsertDetails(Add insert);
        Task<bool> GetEditDetail(UserDetail userDetail);
        //int AddNewBook(UserDetail model);
        //List<UserDetail> GetAllBooks();
        // UserDetail GetBookById(int id);
        //List<UserDetail> SearchBook(string title, string authorName);
    }
}