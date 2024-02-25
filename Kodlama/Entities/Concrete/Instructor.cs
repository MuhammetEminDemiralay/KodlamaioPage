using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Instructor
    {
        public int Id { get; set; }
        public string InstructorFistname { get; set; }
        public string InstructorLastname { get; set; }
        public int Age { get; set; }
    }
}
