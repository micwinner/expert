using AutoMapper;
using instrument.expert.dto;
using instrument.expert.repository;

namespace instrument.expert.bll.Impl
{
    public class IMAdminUserBll : IIMAdminUserBll
    {
        private readonly IIMAdminUserRepository _repository;

        public IMAdminUserBll(IIMAdminUserRepository repository)
        {
            _repository = repository;
        }

        public IM_AdminUserDto Login(string username, string password)
        {
            var model = _repository.GetUser(username, password);
            return model != null ? Mapper.Map<IM_AdminUserDto>(model) : null;
        }
    }
}