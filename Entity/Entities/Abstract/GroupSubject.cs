using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class GroupSubject : ITable
    {
        public Subject Subject { get; set; }
        public int SubjectID { get; set; }
        public Group Group { get; set; }
        public int GroupID { get; set; }
    }
}
