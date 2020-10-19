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
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using static DemoDTO.Models.UserDetail;

namespace DemoRepository.Interface
{
    public class BookRepository : IBookRepository
    {
        private readonly IEntityUsers _entityUsers;
        public BookRepository(IEntityUsers entityUsers)
        {
            _entityUsers = entityUsers;
        }
        //GET-LIST
        public async Task<List<UserDetail>> GetUserDetails()
        {
            var userListDTO = new List<UserDetail>();

            var usersList = await _entityUsers.GetUserDetails();
            userListDTO.AddRange(
            usersList.Select(x => new UserDetail
            {
                UserId = x.UserId,
                FullName = x.FullName,
                UserEmail = x.UserEmail
                //CarLicense = x.CarLicense,
                
            }).ToList());

            //var cardetails = string.Join(",", carDetails.Where(x => x.UserId == x.UserId).Select(y => y.CarLicense).ToList());
            //userListDTO.Add(cardetails);
            return userListDTO;
        }
        //POST-DELETE
        public async Task<bool> Delete(int id)
        {
           await _entityUsers.DeleteUser(id);
            return true;
        }
        //GET-EDIT
        public async Task<UserDetail> GetEditDetail1(int id)
        {
            var viewModel = await _entityUsers.GetEditDetails(id);

            var user = new UserDetail
            {
                UserId = viewModel.UserId,
                UserEmail = viewModel.UserEmail,
                FullName = viewModel.FullName,

            };
            return user;
        }
        //POST-EDIT
        public async Task<bool> GetEditDetail(UserDetail userDetail)
        {
            var user = new UserDetails()
            {
                UserId = userDetail.UserId,
                FullName = userDetail.FullName,
                UserEmail = userDetail.UserEmail
            };
            await _entityUsers.GetEditDetail1(user);
            return true;
        }
        //POST-INSERT
        public async Task<bool> InsertDetails(Add insert)
        {
            var user = new UserDetails()
            {
                UserEmail = insert.UserEmail,
                FullName = insert.FullName,
            };
            var res = await _entityUsers.GetInsertDetails(user);
            return res;
        }



    }

}
