//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tours_Destinations
    {
        public int ID { get; set; }
        public int TourId { get; set; }
        public System.DateTime MeetingDateFrom { get; set; }
        public System.DateTime MeetingDateTo { get; set; }
        public string DestinationAdress { get; set; }
        public System.DateTime DepartureTime { get; set; }
        public System.DateTime ArrivalTime { get; set; }
        public int Deleted { get; set; }
    
        public virtual Tour Tour { get; set; }
    }
}
