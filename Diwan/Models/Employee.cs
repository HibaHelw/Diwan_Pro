using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Models.Base;

namespace DiwanModels.Models
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string Details { get; set; }
        public string EmployeeName => FirstName + " " + LastName;
        public string EmployeeFullName => FirstName + " " + FatherName + " " + LastName;
    }
}
