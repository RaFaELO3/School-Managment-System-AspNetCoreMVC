using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class TeacherGroup : ITable
    {
        public Teacher Teacher { get; set; }
        public int TeacherID { get; set; }
        public Group Group { get; set; }
        public int GroupID { get; set; }
    }
}
