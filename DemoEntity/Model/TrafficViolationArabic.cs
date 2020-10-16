using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class TrafficViolationArabic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Location { get; set; }
        public string ArabicLocation { get; set; }
        public string ArabicDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
