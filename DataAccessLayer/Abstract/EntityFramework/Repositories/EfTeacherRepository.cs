using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Repositories
{
    public class EfTeacherRepository : EfGenericRepository<Teacher> , ITeacherDAL
    {
      
    }
}
