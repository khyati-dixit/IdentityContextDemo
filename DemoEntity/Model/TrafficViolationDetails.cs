using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class TrafficViolationDetails
    {
        public string Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ArabicName { get; set; }
        public string Location { get; set; }
        public string ArabicDescription { get; set; }
        public string LicensePlateNumber { get; set; }
        public string FineAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string CarSpeed { get; set; }
        public string SiteSpeed { get; set; }
        public string Type { get; set; }

        public virtual UserDetails User { get; set; }
    }
}
