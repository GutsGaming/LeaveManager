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
    
    public partial class EmployeeLeaveRequest
    {
        public EmployeeLeaveRequest()
        {
            this.EmployeeLeaveRequestDates = new HashSet<EmployeeLeaveRequestDate>();
            this.EmployeeLeaveRequestStatusChanges = new HashSet<EmployeeLeaveRequestStatusChanx>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid EmployeeID { get; set; }
        public System.DateTime DateTime { get; set; }
        public int LeaveTypeID { get; set; }
    
        public virtual ICollection<EmployeeLeaveRequestDate> EmployeeLeaveRequestDates { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual LeaveType LeaveType { get; set; }
        public virtual ICollection<EmployeeLeaveRequestStatusChanx> EmployeeLeaveRequestStatusChanges { get; set; }
    }
}
