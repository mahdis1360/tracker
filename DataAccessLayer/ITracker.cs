using Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface ITracker
    {
        public Tuple<bool, STANDING> HasGraduated(Diploma diploma, Student student);
       
    }
}
