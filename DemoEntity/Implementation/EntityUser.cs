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
               // var carDetails = new List<CarDetails>();
                //var cardetails = string.Join(",", carDetails.Where(x => x.UserId == x.UserId).Select(y => y.CarLicense).ToList());
                //_context.Add(carDetails);
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
        public async Task<UserDetails> GetEditDetails(int id)
        {
            var viewModel =  await _context.UserDetails.Where(x => x.UserId == id).FirstOrDefaultAsync();
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
            var viewModel = await _context.UserDetails.Where(x => x.UserId == u.UserId).FirstOrDefaultAsync();
            viewModel.UserId = u.UserId;
            viewModel.FullName = u.FullName;
            viewModel.UserEmail = u.UserEmail;
            _context.Entry(viewModel).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        //POST-DELETE
        public async Task<bool> DeleteUser(int id)
        {
            var deleteUser = await _context.UserDetails.Where(x => x.UserId == id).SingleOrDefaultAsync();
            deleteUser.IsActive = false;
            _context.Entry(deleteUser).State = EntityState.Modified;
             //_context.UserDetails.Remove(deleteUser);
             _context.SaveChanges();
            return true;
        }
    }
}
