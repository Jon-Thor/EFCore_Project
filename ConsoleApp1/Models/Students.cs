using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Students
    {
        public int StudentsId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set;}

        public int GroupId { get; set; } 
        public Group Group { get; set; }
    }
}
