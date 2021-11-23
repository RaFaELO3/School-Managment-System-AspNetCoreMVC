using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Speciality : ITable
    {
        public int SpecialityID { get; set; }
        public string SpecialityName { get; set; }

        //Relations
        public List<Student> Students { get; set; }
    }
}
