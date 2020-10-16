using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class DeletedUsers
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public string CivilIdNumber { get; set; }
        public string Dob { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public int? RoleId { get; set; }
        public string ProfilePic { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsNotificationActive { get; set; }
        public bool? IsActive { get; set; }
        public int? DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string FcmToken { get; set; }
        public bool? Verify { get; set; }
        public string VerifiedBy { get; set; }
        public string Area { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public string Housing { get; set; }
        public string Floor { get; set; }
        public string NewPass { get; set; }
        public string ConPass { get; set; }
        public string Jadda { get; set; }
        public string Reason { get; set; }
    }
}
