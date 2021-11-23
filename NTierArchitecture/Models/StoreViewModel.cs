using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.Models
{
    public class StoreViewModel
    {
        public List<Teacher> teachers { get; set; }
        public List<Student> students { get; set; }
    }
}
