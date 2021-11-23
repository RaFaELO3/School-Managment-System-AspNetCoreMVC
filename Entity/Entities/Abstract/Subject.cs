using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Subject : ITable
    {
        //Properties
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

        //Relations
        public List<Teacher> Teachers { get; set; }
        public List<GroupSubject> groupSubject { get; set; }
    }   
}
