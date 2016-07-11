/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：a2fe7df1-89f8-4398-b9fd-f2448bdd2ee8
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.repository
 * 类名称：IIMSortClassRepository
 * 文件名：IIMSortClassRepository
 * 创建年份：2016
 * 创建时间：2016/4/1 15:04:01
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;
using instrument.expert.model;
using instrument.expert.model.extendmodel;

namespace instrument.expert.repository
{
    public interface IIMSortClassRepository : IRepository<IM_SortClass>
    {
        IList<IMSortClass_Sql> GetListBySql(string id);
    }
}