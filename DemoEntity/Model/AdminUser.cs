using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class AdminUser
    {
        public int AdminId { get; set; }
        public string FullName { get; set; }
        public string AdminEmailId { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
    }
}
