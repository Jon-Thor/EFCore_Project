using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Marks
    {
        public int MarksId { get; set; }

        public int StudentsId { get; set; }

        public Students Students { get; set; }
        public int SubjectsId { get; set; }

        public Subjects Subjects { get; set; }

        public DateTime date { get; set; } 

        public int Mark { get; set; }
    }
}
