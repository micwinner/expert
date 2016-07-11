using System;
using instrument.expert.model;

namespace instrument.expert.repository.Impl
{
    public class IMAdminUserRepository : Repository<IM_Admin_User>, IIMAdminUserRepository
    {
        public IM_Admin_User GetUser(string username, string password)
        {
            try
            {
                username = username.Trim();
                //var md5Pass = Utils.MD5(password.Trim()).ToLower();
                var md5Pass = password;
                return GetByFunc(model => model.admin_name == username && model.admin_password == md5Pass);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}