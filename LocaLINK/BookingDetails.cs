//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocaLINK
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingDetails
    {
        public int id { get; set; }
        public Nullable<int> booking_id { get; set; }
        public Nullable<int> service_id { get; set; }
        public string Price { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Service_Provider Service_Provider { get; set; }
    }
}
