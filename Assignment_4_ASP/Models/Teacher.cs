﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_4_ASP.Models
{
    public class Teacher
    {
        //Teacher columns
        public int TeacherId;
        public string TeacherFname;
        public string TeacherLname;
        public string TeacherEmployeeNumber;
        public DateTime TeacherHireDate;
        public decimal TeacherSalary;

        public Teacher() { }
    }
}