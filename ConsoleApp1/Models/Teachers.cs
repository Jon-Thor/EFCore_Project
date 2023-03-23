using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Teachers
    {
        public int TeachersId { get; set; }  

        public string FirstName { get;set; }
        public string LastName { get; set;}

        public List<Subjects> Subjects { get; set; }
    }
}
