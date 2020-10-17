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
        Task<bool> GetInsertDetails(UserDetails insert);
        Task<bool> DeleteUser(int? id);
        Task<bool> GetEditDetail1(UserDetails u);
        Task<UserDetails> GetEditDetails(int? id);
    }
}
