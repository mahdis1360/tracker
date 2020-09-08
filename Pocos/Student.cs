using System;
using System.Collections.Generic;
using System.Text;

namespace Pocos
{
    public class Student:IPoco
    {
        public int Id { get; set; }
        public Course[] Courses { get; set; }
        public STANDING Standing { get; set; } = STANDING.None;
    }
}
