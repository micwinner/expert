/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：b09a417b-fabf-40e5-a8fe-be18576217b3
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.repository.Impl
 * 类名称：IMSortClassRepository
 * 文件名：IMSortClassRepository
 * 创建年份：2016
 * 创建时间：2016/4/1 15:05:02
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using instrument.expert.model;
using instrument.expert.model.extendmodel;

namespace instrument.expert.repository.Impl
{
    public class IMSortClassRepository : Repository<IM_SortClass>, IIMSortClassRepository
    {
        public IList<IMSortClass_Sql> GetListBySql(string id)
        {
            var list =
                DB.Database.SqlQuery<IMSortClass_Sql>("select IMType,IMNote from IM_SortClass where IMSortType = @id",
                    new SqlParameter {ParameterName = "id", Value = id});
            return list.ToList();
        }
    }
}