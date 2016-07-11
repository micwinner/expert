/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：bcda977d-6605-4252-b179-db1296609d39
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll
 * 类名称：IVIPZoneProvinceBll
 * 文件名：IVIPZoneProvinceBll
 * 创建年份：2016
 * 创建时间：2016/3/29 18:24:32
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
    public interface IVIPZoneProvinceBll
    {
        IList<VIPZone_ProvinceDto> GetProvinceListByCountryID(int id);
    }
}