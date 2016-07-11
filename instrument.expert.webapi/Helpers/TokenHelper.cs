using System;

namespace instrument.expert.webapi.Helpers
{
    public class TokenHelper
    {
        /// 生成 token 值
        public string CreateToken()
        {
            var guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}