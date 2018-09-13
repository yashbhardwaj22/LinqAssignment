using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3.Models
{
    public  class Result
    {
        public  List<StudentJoin> GetResult(StudentSearchAttribute searchData)
        {
            if (searchData.MaxRange == 0)
            {
                searchData.MaxRange = 999999999;
            }
            List<StudentView> Data = StudentViewData.GetData();
            List<StudentSalary> Salary = StudentSalaryData.GetData();
            List<StudentJoin> studentJoinList = (from info in Data
                                                 join salary in Salary on info.StudentID equals salary.StudentID
                                                 where isAttribute(info, searchData.SearchByAttribute, searchData.SearchText)
                                                 && (salary.StudentFees >= searchData.MinRange && salary.StudentFees <= searchData.MaxRange)
                                                 select new StudentJoin
                                                 {
                                                     StudentID = info.StudentID,
                                                     StudentName = info.StudentName,
                                                     StudentClass = info.StudentClass,
                                                     StudentAge = info.StudentAge,
                                                     StudentFees = salary.StudentFees,
                                                     Date = salary.Date
                                                 }
                                                     ).ToList();
            StudentList sendData = new StudentList();
            sendData.StudentListData = Sort(studentJoinList, searchData.SortByAttribute);
            return sendData.StudentListData;
        }
        private List<StudentJoin> Sort(List<StudentJoin> std, string sortByAttribute)
        {
            if (sortByAttribute == "StudentID")
                std = (from std_object in std
                       orderby std_object.StudentID
                       select std_object).ToList();

            if (sortByAttribute == "StudentName")
                std = (from std_object in std
                       orderby std_object.StudentName
                       select std_object).ToList();
            if (sortByAttribute == "StudentClass")
                std = (from std_object in std
                       orderby std_object.StudentClass
                       select std_object).ToList();

            return std;
        }

        private bool isAttribute(StudentView std, string searchByAttribute, string searchText)
        {
            if (searchByAttribute == "StudentName")
            {
                if (std.StudentName == searchText)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (searchByAttribute == "StudentClass")
            {
                int number;
                if (!int.TryParse(searchText, out number))
                    return false;
                if (std.StudentClass == Convert.ToInt32(searchText))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (searchByAttribute == "StudentID")
            {
                int number;
                if (!int.TryParse(searchText, out number))
                    return false;

                if (std.StudentID == Convert.ToInt32(searchText))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }



    }
}
