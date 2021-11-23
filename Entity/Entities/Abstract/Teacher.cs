using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Teacher : ITable
    {       
        //Properties
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Relations
        public Department Department { get; set; }
        public int DepartmentID { get; set; }
        public Subject Subject { get; set; }
        public int SubjectID { get; set; }
        public List<TeacherGroup> teacherGroup { get; set; }
    }
}
