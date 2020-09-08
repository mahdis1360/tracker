using DataAccessLayer;
using Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BusinessLogicLayer
{
    public class GraduationTracker : ITracker
    {
        private IDataRepository _datarepository;
  

        public GraduationTracker(IDataRepository dataRepository)
        {
            _datarepository = dataRepository;
        }

        public Tuple<bool, STANDING> HasGraduated(Diploma diploma, Student student)
        {
            float credits = 0;
            float sum = 0;
            float average = 0;
            var requirments = diploma.Requirements.Select(_datarepository.GetRequirement).ToArray();
            foreach (var requirement in requirments)
            {
                foreach (var id in requirement.Courses)
                {
                    var course = student.Courses.First(c => c.Id == id);
                    sum += course.Mark;
                    if (course.Mark > requirement.MinimumMark)
                    {
                        credits += requirement.Credits;
                    }
                }
            }
            average = sum / student.Courses.Length;
            var standing = SearchStanding(average);

            if (credits>= diploma.Credits && standing!= STANDING.Remedial)
            {
                return new Tuple<bool, STANDING>(true, standing);
            }
            else
            {
                return  new Tuple<bool, STANDING>(false, standing);
            }
        }

        public static STANDING SearchStanding(float average)
        {
            if (average < 50)
            {
                return STANDING.Remedial;
            }
            if (average < 80)
            {
                return STANDING.Average;
            }
            if (average < 95)
            {
                return STANDING.MagnaCumLaude;
            }
            else
            {
                return STANDING.SumaCumLaude;
            }

        }
    }


}