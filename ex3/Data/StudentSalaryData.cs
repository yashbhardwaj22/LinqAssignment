using ex3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3.Models
{
    public class StudentSalaryData
    {
        public static List<StudentSalary> GetData()
        {
            return new List<StudentSalary>
            {
                new StudentSalary
                {
                    StudentFees=5000,
                    StudentID =123,
                    Date ="12-Jan-2018"
                },
                new StudentSalary
                {
                    StudentFees=2000,
                    Date="16-Aug-2017",
                    StudentID =153,
                },
                new StudentSalary
                {
                    StudentFees=3000,
                    Date="16-Sep17",
                    StudentID =163,
                },
                new StudentSalary
                {
                    StudentFees=2500,
                    Date="17-Oct-2017",
                    StudentID =111,

                },
                new StudentSalary
                {
                    StudentFees=2000,
                    Date="10-Dec-2017",
                    StudentID =122,
                },
                new StudentSalary
                {
                    StudentFees =3000,
                    Date="16-Feb-2017",
                    StudentID =145,
                },
                new StudentSalary
                {
                    StudentFees=2000,
                    Date="20-May-2017",
                    StudentID =120,
                },
                new StudentSalary
                {
                    StudentFees=4000,
                    Date="25-Jun-2017",
                    StudentID =158,
                },
                new StudentSalary
                {
                    StudentFees=4500,
                    Date="31-Aug-2018",
                    StudentID =200,
                },
                new StudentSalary
                {
                    StudentFees=5050,
                    Date="25-Mar-2017",
                    StudentID =127,
                }
            };
        }

    }
}
