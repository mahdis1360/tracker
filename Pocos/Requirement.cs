using System;
using System.Collections.Generic;
using System.Text;

namespace Pocos
{
    public class Requirement:IPoco
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinimumMark { get; set; }
        public int Credits { get; set; }
        public int[] Courses { get; set; }
    }
}
