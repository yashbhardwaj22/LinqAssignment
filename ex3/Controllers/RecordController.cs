using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ex3.Models;

namespace ex3.Controllers
{
    public class RecordController : Controller
    {
        public IActionResult Index()
        {
            List<StudentView> Info = StudentViewData.GetData();
            List<StudentSalary> Salary = StudentSalaryData.GetData();
            List<StudentJoin> studentJoinList = (from info in Info
                                                     join salary in Salary
                                                     on info.StudentID equals salary.StudentID
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
            StudentList sendViewStudentData = new StudentList();
            sendViewStudentData.StudentListData = studentJoinList;
            return View(sendViewStudentData);


        }
        [HttpPost]
        public IActionResult Index(StudentSearchAttribute searchData)
        {
            Result resultobject = new Result();
            List<StudentJoin> studentListData = resultobject.GetResult(searchData);
            return PartialView("_StudentPartialView", studentListData);
        }
       
    }
}