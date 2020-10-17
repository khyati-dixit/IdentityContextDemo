using DemoEntity.Data;
using DemoEntity.Interface;
using DemoEntity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntity.Implementation
{
    public class EntityUsers : IEntityUsers
    {
        private readonly traffictraineesContext _context;

        public EntityUsers(traffictraineesContext context)
        {
            _context = context;
        }
        //LIST
        public async Task<List<UserDetails>> GetUserDetails()
        {
            try
            {
                return await _context.UserDetails.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        //INSERT
        public async Task<bool> GetInsertDetails(UserDetails insert)
        {
            await _context.UserDetails.AddAsync(insert);
            await _context.SaveChangesAsync();
            return true;
        }
        //GET-EDIT
        public async Task<UserDetails> GetEditDetails(int? id)
        {
            var viewModel =  _context.UserDetails.Where(x => x.UserId == id).FirstOrDefault();
            var userDetails = new UserDetails
            {
                UserId = viewModel.UserId,

                FullName = viewModel.FullName,
                UserEmail = viewModel.UserEmail

            };
            return userDetails;
        }
        //POST-EDIT
        public async Task<bool> GetEditDetail1(UserDetails u)
        {
            var viewModel =  _context.UserDetails.Where(x => x.UserId == u.UserId).FirstOrDefault();
            viewModel.UserId = u.UserId;
            viewModel.FullName = u.FullName;
            viewModel.UserEmail = u.UserEmail;
            _context.Entry(viewModel).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        //POST-DELETE
        public async Task<bool> DeleteUser(int? id)
        {
            var deleteUser = _context.UserDetails.Where(x => x.UserId == id).SingleOrDefault();
             _context.UserDetails.Remove(deleteUser);
             _context.SaveChanges();
            return true;
        }
    }
}
