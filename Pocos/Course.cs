using System;
using System.Collections.Generic;
using System.Text;

namespace Pocos
{
   public  class Course :IPoco
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Credits { get; }
    }
}
