using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDataTempDemo.Models;
namespace ViewBagDataTempDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> studentList = new List<Student>
            {
                new Student {StdRollNo=100,StdName="Scott"},
                 new Student {StdRollNo=101,StdName="Tiger"},
                 new Student{StdRollNo=101,StdName="Smith"}
            };
            ViewData["students"] = studentList;
            ViewData["count"] = studentList.Count;
            return View();
        }

        public ActionResult Index1()
        {
          var result=  ViewData["students"];
            var  result1 = ViewBag.students;
            return new EmptyResult();
        }

        public ActionResult ShowStudents()
        {
            List<Student> studentList = new List<Student>
            {
                new Student {StdRollNo=100,StdName="Scott"},
                 new Student {StdRollNo=101,StdName="Tiger"},
                 new Student{StdRollNo=101,StdName="Smith"}
            };
            ViewBag.students = studentList;
            ViewBag.count = studentList.Count;
            return View();
        }

        public ActionResult ShowStudentInfo()
        {
            TempData["rollno"] = 100;
            return RedirectToAction("PrintRollNo");
        }

        public ActionResult PrintRollNo()
        {
            TempData.Keep("rollno");
            return View();
        }
    }
}