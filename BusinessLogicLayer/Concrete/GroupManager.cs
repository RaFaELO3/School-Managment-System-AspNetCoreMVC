using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class GroupManager : IGroupService
    {
        private readonly IGroupDAL _groupRepository;
        public GroupManager(IGroupDAL groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public void Add(Group entity)
        {
            _groupRepository.Add(entity);
        }

        public void Delete(Group entity)
        {
            _groupRepository.Delete(entity);
        }

        public List<Group> Get()
        {
            return _groupRepository.Get();
        }

        public Group GetById(int id)
        {
            return _groupRepository.GetById(id);
        }

        public void Update(Group entity)
        {
            _groupRepository.Update(entity);
        }
    }
}
