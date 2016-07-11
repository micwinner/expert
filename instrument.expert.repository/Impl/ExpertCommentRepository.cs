/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：b6c353d4-c855-4c28-b07a-30ea06c4438c
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.repository
 * 类名称：ExpertCommentRepository
 * 文件名：ExpertCommentRepository
 * 创建年份：2016
 * 创建时间：2016/4/11 10:53:03
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Linq;
using instrument.expert.model;

namespace instrument.expert.repository.Impl
{
    public class ExpertCommentRepository : Repository<EXP_Comment>, IExpertCommentRepository
    {
        public bool Exist(string eid)
        {
            return DB.EXP_Comment.FirstOrDefault(m => m.expertid == eid) != null;
        }
    }
}