using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex3.Models;

namespace ex3.Models
{
    public class StudentViewData
    {
        public static List<StudentView> GetData()
        {
            return new List<StudentView>
            {
                new StudentView
                {
                    StudentName="yash",
                    StudentID =123,
                    StudentClass = 12,
                    StudentAge = 18
                },
                new StudentView
                {
                    StudentName="Lakshay",
                    StudentID =153,
                    StudentClass = 11,
                    StudentAge = 17
                },
                new StudentView
                {
                    StudentName="vineet",
                    StudentID =163,
                    StudentClass = 10,
                    StudentAge = 15
                },
                new StudentView
                {
                    StudentName="ramesh",
                    StudentID =111,
                    StudentClass = 10,
                    StudentAge = 14
                },
                new StudentView
                {
                    StudentName="Amrit",
                    StudentID =122,
                    StudentClass = 12,
                    StudentAge = 19
                },
                new StudentView
                {
                    StudentName="Komal",
                    StudentID =145,
                    StudentClass = 9,
                    StudentAge = 13
                },
                new StudentView
                {
                    StudentName="Hasan",
                    StudentID =121,
                    StudentClass = 12,
                    StudentAge = 18
                },
                new StudentView
                {
                    StudentName="Ajit",
                    StudentID =158,
                    StudentClass = 11,
                    StudentAge = 16
                },
                new StudentView
                {
                    StudentName="Tanveer",
                    StudentID =129,
                    StudentClass = 12,
                    StudentAge = 18
                },
                new StudentView
                {
                    StudentName="Rohit",
                    StudentID =127,
                    StudentClass = 8,
                    StudentAge = 12
                }
            };
        }

    }
}
