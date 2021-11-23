using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Group : ITable
    {
        //Properties
        public int GroupID { get; set; }
        public string GroupName { get; set; }

        //Relations
        public List<Student> Students { get; set; }
        public List<GroupSubject> groupSubject { get; set; }
        public List<TeacherGroup> teacherGroup { get; set; }

    }
}
