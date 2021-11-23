using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherDAL _teacherRepository;

        public TeacherManager(ITeacherDAL teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public void Add(Teacher entity)
        {
            _teacherRepository.Add(entity);
        }

        public void Delete(Teacher entity)
        {
            _teacherRepository.Delete(entity);
        }

        public List<Teacher> Get()
        {
            return _teacherRepository.Get();
        }

        public Teacher GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }

        public void Update(Teacher entity)
        {
            _teacherRepository.Update(entity);
        }
    }
}
