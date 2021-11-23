using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class SubjectManager : ISubjectService
    {
        private readonly ISubjectDAL _subjectRepository;
        public SubjectManager(ISubjectDAL subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void Add(Subject entity)
        {
            _subjectRepository.Add(entity);
        }

        public void Delete(Subject entity)
        {
            _subjectRepository.Delete(entity);

        }

        public List<Subject> Get()
        {
            return _subjectRepository.Get();
        }

        public Subject GetById(int id)
        {
            return _subjectRepository.GetById(id);

        }

        public void Update(Subject entity)
        {
            _subjectRepository.Update(entity);
        }
    }
}
