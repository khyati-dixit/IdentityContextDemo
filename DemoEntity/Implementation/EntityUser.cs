using DemoEntity.Data;
using DemoEntity.Interface;
using DemoEntity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task GetInsertDetails(UserDetails insert)
        {
            try
            {
                 await _context.UserDetails.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public async Task<List<UserDetails>> GetEditDetails(int id)
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
        public async Task GetEditDetails(UserDetails insert)
        {
            try
            {
                await _context.UserDetails.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public async Task DeleteUser(int? id)
        {
            try
            {
                await _context.UserDetails.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
