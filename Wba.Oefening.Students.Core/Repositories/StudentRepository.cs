using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wba.Oefening.Students.Core.Entities;

namespace Wba.Oefening.Students.Core.Repositories
{
    public class StudentRepository
    {
        //return 4 students
        public IEnumerable<Student> GetAll()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Firstname = "Bart",
                    Lastname = "Soete",
                    Course = "WFA",
                },
                new Student
                {
                    Id = 2,
                    Firstname = "Mike",
                    Lastname = "Tyson",
                    Course = "WBA",
                },
                new Student
                {
                    Id = 3,
                    Firstname = "Walter",
                    Lastname = "Capiau",
                    Course = "WFA",
                },
                new Student
                {
                    Id = 4,
                    Firstname = "Frank",
                    Lastname = "Zappa",
                    Course = "WBA",
                },
            };
        }
    }
}
