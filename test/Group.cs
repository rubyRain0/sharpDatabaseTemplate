using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Group
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public List<Student> Students { get; set; } = new(); //navigation 
        public Direction? Direction { get; set; }   

    }
}
