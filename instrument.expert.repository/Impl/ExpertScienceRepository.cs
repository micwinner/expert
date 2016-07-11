/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：ee9a894d-201f-4008-9393-51dbedcb7df4
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.repository.Impl
 * 类名称：ExpertScienceRepository
 * 文件名：ExpertScienceRepository
 * 创建年份：2016
 * 创建时间：2016/4/8 16:00:29
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
    public class ExpertScienceRepository : Repository<EXP_ExpertScience>, IExpertScienceRepository
    {
        public bool Exist(string eid)
        {
            return DB.EXP_ExpertScience.FirstOrDefault(m => m.expertid == eid) != null;
        }
    }
}