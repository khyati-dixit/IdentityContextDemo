using System;
using System.Collections.Generic;

namespace DemoEntity.Model
{
    public partial class Events
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventImage1 { get; set; }
        public string EventImage2 { get; set; }
        public string EventImage3 { get; set; }
        public int Notifications { get; set; }
        public string Time { get; set; }
        public bool IsDelete { get; set; }
        public bool? IsArchived { get; set; }
        public string ExpireDate { get; set; }
        public string ExpireTime { get; set; }
        public bool? IsExpired { get; set; }
        public string RoadStreet { get; set; }
        public string Location { get; set; }
        public string Direction { get; set; }
        public string Other { get; set; }
        public string EventDescription { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
