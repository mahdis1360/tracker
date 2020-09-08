using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pocos;
using BusinessLogicLayer;
namespace TesstGraduated
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrenge 
            Student Student = new Student()
            {
                Id = 1,
                Courses = new Course[]
                     {
                        new Course{Id = 1, Name = "Math", Mark=95 },
                        new Course{Id = 2, Name = "Science", Mark=95 },
                        new Course{Id = 3, Name = "Literature", Mark=95 },
                        new Course{Id = 4, Name = "Physichal Education", Mark=95 }
                     }
            };


            Diploma diploma =new Diploma()
            {
                   
            Id = 1,
            Credits = 4,
            Requirements = new int[] { 100, 102, 103, 104 }
            };


            //act 
             GraduationTracker tracker = new GraduationTracker(new Repository());
               var graduated = tracker.HasGraduated(diploma,Student);

            // assert 
            Assert.IsTrue(graduated.Item1 == true && graduated.Item2 == STANDING.SumaCumLaude);
        }
    }
}
