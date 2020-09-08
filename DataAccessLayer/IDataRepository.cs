using Pocos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer
{
   public interface IDataRepository
    {
        Student GetStudent(int id);

        Diploma GetDiploma(int id);

        Requirement GetRequirement(int id);
    }
}
