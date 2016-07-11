using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;
/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：3e08648a-0c5f-46b0-94fc-406d11443025
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：ExpertRecordsProfile
 * 文件名：ExpertRecordsProfile
 * 创建年份：2016
 * 创建时间：2016/4/11 17:48:22
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.mapper.Profiles
{
    public class ExpertRecordsProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<EXP_Records, EXP_RecordsDto>();
            CreateMap<EXP_RecordsDto, EXP_Records>();
        }
    }
}