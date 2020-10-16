using DemoEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntity.Interface
{
    public interface IEntityUsers
    {
        Task<List<UserDetails>> GetUserDetails();
        Task GetInsertDetails(UserDetails insert);
        Task DeleteUser(int? id);
        Task GetEditDetails(UserDetails insert);
        Task<List<UserDetails>> GetEditDetails(int id);
    }
}
