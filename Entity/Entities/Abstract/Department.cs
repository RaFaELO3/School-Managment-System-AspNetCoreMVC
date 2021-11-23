using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Department : ITable
    {
        //Properties
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        //Relations
        public List<Teacher> Teachers { get; set; }
    }
}
