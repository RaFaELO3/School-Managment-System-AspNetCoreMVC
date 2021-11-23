using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDAL _departmentRepository;
        public DepartmentManager(IDepartmentDAL departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public void Add(Department entity)
        {
            _departmentRepository.Add(entity);
        }

        public void Delete(Department entity)
        {
            _departmentRepository.Delete(entity);
        }

        public List<Department> Get()
        {
            return _departmentRepository.Get();
        }

        public Department GetById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void Update(Department entity)
        {
            _departmentRepository.Update(entity);
        }
    }
}
