//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logic
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveStatus
    {
        public LeaveStatus()
        {
            this.EmployeeLeaveRequestStatusChanges = new HashSet<EmployeeLeaveRequestStatusChanx>();
        }
    
        public int ID { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<EmployeeLeaveRequestStatusChanx> EmployeeLeaveRequestStatusChanges { get; set; }
    }
}