using DemoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDTO.Models
{
    public class UserDetail
    {
        //public UserDetail()
        //{
        //    CarDetails = new List<carDetailsUser>();
        //}
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public string CivilIdNumber { get; set; }
        public string CarLicense { get; set; }
        //public List<carDetailsUser> CarDetails { get; set; }
        public class Add
        {
            
            public string FullName { get; set; }
            public string UserEmail { get; set; }
        }
        
        //public virtual ICollection<CarDetails> CarDetails { get; set; }
    }
    //public class carDetailsUser
    //{
    //    public int Id { get; set; }
    //    public string CarLicenseValue { get; set; }
    //}
}
