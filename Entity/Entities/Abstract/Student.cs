using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Student : ITable
    {
        //Properties
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Relations
        public Group Group { get; set; }
        public int GroupID { get; set; }
        public Speciality Speciality { get; set; }
        public int SpecialityID { get; set; }
    }

}
