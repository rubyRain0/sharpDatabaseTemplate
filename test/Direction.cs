using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Direction
    {
        public int DirectionId { get; set; }
        public string? DirectionName { get; set; }


        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
