﻿using System.Data.Entity;
using Logic;

namespace Interface.Models
{
    public class BookLeaveModel
    {
        public DbSet<LeaveType> LeaveTypes { get; set; }

        public Employee CurrentUser { get; set; }
    }
}