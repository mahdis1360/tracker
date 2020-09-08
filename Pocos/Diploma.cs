using System;
using System.Collections.Generic;
using System.Text;

namespace Pocos
{
    public class Diploma:IPoco
    {
        public int Id { get; set; }
        public int Credits { get; set; }
        public int[] Requirements { get; set; }
    }
}
