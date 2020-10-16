using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class DeletedCarDetails
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string CarLicense { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
