using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDAL _studentRepository;

        public StudentManager(IStudentDAL studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Add(Student entity)
        {
            _studentRepository.Add(entity);
        }

        public void Delete(Student entity)
        {
            _studentRepository.Delete(entity);
        }

        public List<Student> Get()
        {
            return _studentRepository.Get();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void Update(Student entity)
        {
            _studentRepository.Update(entity);

        }
    }
}
 