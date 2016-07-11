/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：509b920b-6eda-4744-9f4a-23acaf3c5103
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll
 * 类名称：IExpertRecordsBll
 * 文件名：IExpertRecordsBll
 * 创建年份：2016
 * 创建时间：2016/4/11 17:43:39
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IExpertRecordsBll
    {
        IList<EXP_RecordsDto> GetList(int page, int pagesize, out int count);
        IList<EXP_RecordsDto> GetListByEID(string eid, int page, int pagesize, out int count);
        EXP_RecordsDto GetOne(int id);
        int Update(EXP_RecordsDto model);
        int Add(EXP_RecordsDto model);
        int Delete(int id);
    }
}