﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Screen
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string age { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string mob { get; set; }
        public double gpa { get; set; }
        // public int ModuleId { get; set; } // foreign key property
       // public Module Module { get; set; } // navigation property

    }
}
