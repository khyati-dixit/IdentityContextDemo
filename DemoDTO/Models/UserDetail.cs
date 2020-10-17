using DemoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDTO.Models
{
    public class UserDetail
    {
        public UserDetail()
        {
            CarDetails = new HashSet<CarDetails>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public string CivilIdNumber { get; set; }
        public string CarLicense { get; set; }
        //public string Dob { get; set; }
        //public string MobileNo { get; set; }
        //public string Address { get; set; }
        //public int? RoleId { get; set; }
        //public string ProfilePic { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        //public bool? IsNotificationActive { get; set; }
        //public bool? IsActive { get; set; }
        //public int? DeviceId { get; set; }
        //public string DeviceType { get; set; }
        //public string FcmToken { get; set; }
        //public bool? Verify { get; set; }
        //public string VerifiedBy { get; set; }
        //public string Area { get; set; }
        //public string Block { get; set; }
        //public string Street { get; set; }
        //public string Housing { get; set; }
        //public string Floor { get; set; }
        //public string NewPass { get; set; }
        //public string ConPass { get; set; }
        //public string Jadda { get; set; }
        //public string Reason { get; set; }
        //public string ActivatedBy { get; set; }
        //public DateTime? VerifiedDate { get; set; }
        //public DateTime? ActivatedDate { get; set; }
        public class Add
        {
            
            public string FullName { get; set; }
            public string UserEmail { get; set; }
        }

        public virtual ICollection<CarDetails> CarDetails { get; set; }
    }
}
