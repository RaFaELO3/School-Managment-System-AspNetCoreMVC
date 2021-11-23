using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class SpecialityManager : ISpecialityService
    {
        private readonly ISpecialityDAL _specialityRepository;
        public SpecialityManager(ISpecialityDAL specialityRepository)
        {
            _specialityRepository = specialityRepository;
        }

        public void Add(Speciality entity)
        {
            _specialityRepository.Add(entity);
        }

        public void Delete(Speciality entity)
        {
            _specialityRepository.Delete(entity);

        }

        public List<Speciality> Get()
        {
            return _specialityRepository.Get();
        }

        public Speciality GetById(int id)
        {
            return _specialityRepository.GetById(id);

        }

        public void Update(Speciality entity)
        {
            _specialityRepository.Update(entity);
        }
    }
}
