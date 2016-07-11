using System.ComponentModel.DataAnnotations;

namespace instrument.expert.dto
{
    public class IM_AdminUserDto
    {
        public int id { get; set; }
        public string admin_id { get; set; }

        [Required(ErrorMessage = "用户名不能为空！")]
        public string admin_name { get; set; }

        [Required(ErrorMessage = "密码不能为空！")]
        public string admin_password { get; set; }

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}