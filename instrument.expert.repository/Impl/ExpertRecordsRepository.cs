/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：03cd799a-8756-4ee6-83a9-4fe5e1a88f87
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.repository.Impl
 * 类名称：ExpertRecordsRepository
 * 文件名：ExpertRecordsRepository
 * 创建年份：2016
 * 创建时间：2016/4/11 17:37:23
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;
using System.Linq;
using instrument.expert.model;

namespace instrument.expert.repository.Impl
{
    public class ExpertRecordsRepository : Repository<EXP_Records>, IExpertRecordsRepository
    {
        public IList<EXP_Records> GetList(int page, int pagesize, out int count)
        {
            count = DB.EXP_Records.Count();
            return DB.EXP_Records.OrderBy(m => m.ID).Skip((page - 1)*pagesize).Take(pagesize).ToList();
        }

        public IList<EXP_Records> GetListByEID(string eid, int page, int pagesize, out int count)
        {
            count = DB.EXP_Records.Count(m => m.expertid == eid);
            return
                DB.EXP_Records.Where(m => m.expertid == eid)
                    .OrderBy(m => m.ID)
                    .Skip((page - 1)*pagesize)
                    .Take(pagesize)
                    .ToList();
        }
    }
}