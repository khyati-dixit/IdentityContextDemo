using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class TrafficViolationDat
    {
        public string Key { get; set; }
        public string Id { get; set; }
        public string Purpose { get; set; }
        public string Detail { get; set; }
        public string CarNo { get; set; }
        public string CarSmallNo { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string CarSpeed { get; set; }
        public string SiteSpeed { get; set; }
        public string Site { get; set; }
        public string Country { get; set; }
        public string Zone { get; set; }
        public string Category { get; set; }
        public string Usage { get; set; }
        public string Cd { get; set; }
        public string Characters { get; set; }
        public string Governorate { get; set; }
        public string Color { get; set; }
        public bool? NotificationSent { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TotalRecord { get; set; }
    }
}
