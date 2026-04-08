using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public float Grade;

        public abstract bool IsPassed(float grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(float grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(float grade)
        {
            return grade > 80.0;
        }
    }
    internal class student_grade
    {
        static void Main(string[] args)
        {
            Undergraduate ug = new Undergraduate()
            {
                Name = "Subha",
                StudentId = 1,
                Grade = 85
            };
            Graduate grad = new Graduate()
            {
                Name = "Sathya",
                StudentId = 2,
                Grade = 78
            };

            Console.WriteLine("Name : " + ug.Name + "  StudentId : "+ ug.StudentId + "  grade :"+ ug.Grade + "  Undergraduate Passed: " + ug.IsPassed(ug.Grade));
            Console.WriteLine("Name : " + grad.Name + "  StudentId : " + grad.StudentId + "  grade :" + grad.Grade + "  Graduate Passed: " + grad.IsPassed(ug.Grade));

        }
    }
}



