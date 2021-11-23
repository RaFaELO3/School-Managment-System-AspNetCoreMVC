using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SchoolManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Controllers
{

    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;
        private readonly ISubjectService _subjectService;
        private readonly ISpecialityService _specialityService;
        private readonly IDepartmentService _departmentService;
        private readonly IGroupService _groupService;
        public HomeController(IStudentService studentService,
                              ITeacherService teacherService,
                              ISubjectService subjectService,
                              ISpecialityService specialityService,
                              IDepartmentService departmentService,
                              IGroupService groupService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
            _subjectService = subjectService;
            _specialityService = specialityService;
            _departmentService = departmentService;
            _groupService = groupService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Students()
        {
            return View();
        }
        public IActionResult StudentsList()
        {
            return View();
        }
        public IActionResult Teachers()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public JsonResult GetStudents()
        {
            StoreViewModel model = new StoreViewModel();
            model.students = _studentService.Get();
            foreach (var item in model.students)
            {
                item.Speciality = _specialityService.GetById(item.SpecialityID);
                item.Group = _groupService.GetById(item.GroupID);
            }

            return Json(model);
        }
        public JsonResult GetTeachers()
        {
            StoreViewModel model = new StoreViewModel();
            model.teachers = _teacherService.Get();
            foreach (var item in model.teachers)
            {
                item.Subject = _subjectService.GetById(item.SubjectID);
            }

            return Json(model);
        }
        public JsonResult GetSubjects()
        {
            var subject = _subjectService.Get();
            return Json(subject);
        }
        public JsonResult GetSpecialities()
        {
            var speciality = _specialityService.Get();
            return Json(speciality);
        }
        public JsonResult GetDepartments()
        {
            var departments = _departmentService.Get();
            return Json(departments);
        }
        public JsonResult GetGroups()
        {
            var groups = _groupService.Get();
            return Json(groups);
        }
    }
}
