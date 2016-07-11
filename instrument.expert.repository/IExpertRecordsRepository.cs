/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：feb9d1a2-f730-4f13-bbab-ccb321943c9c
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.repository
 * 类名称：IExpertRecordsRepository
 * 文件名：IExpertRecordsRepository
 * 创建年份：2016
 * 创建时间：2016/4/11 17:34:42
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;
using instrument.expert.model;

namespace instrument.expert.repository
{
    public interface IExpertRecordsRepository : IRepository<EXP_Records>
    {
        IList<EXP_Records> GetList(int page, int pagesize, out int count);
        IList<EXP_Records> GetListByEID(string eid, int page, int pagesize, out int count);
    }
}