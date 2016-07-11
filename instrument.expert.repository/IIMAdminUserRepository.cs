using instrument.expert.model;

namespace instrument.expert.repository
{
    public interface IIMAdminUserRepository : IRepository<IM_Admin_User>
    {
        IM_Admin_User GetUser(string username, string password);
    }
}