using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAssignmentMVC.Models
{
    public class StudentModel
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string StuState { get; set; }
        public string Country { get; set; }
    }
}