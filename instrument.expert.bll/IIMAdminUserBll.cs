using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IIMAdminUserBll
    {
        IM_AdminUserDto Login(string username, string password);
    }
}