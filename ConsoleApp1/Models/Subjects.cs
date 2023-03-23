using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Subjects
    {
        public int SubjectsId { get; set; }

        public string Title { get; set; }

        public List<Teachers> Teachers { get; set; }
        public List<Marks> Marks { get; set; }

    }
}
