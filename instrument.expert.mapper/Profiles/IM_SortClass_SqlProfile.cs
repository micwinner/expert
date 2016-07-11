using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;
using instrument.expert.model.extendmodel;

/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：3071cd90-56cc-4982-afda-67e6f5a62e7c
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：IM_SortClass_SqlProfile
 * 文件名：IM_SortClass_SqlProfile
 * 创建年份：2016
 * 创建时间：2016/4/5 10:51:36
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.mapper.Profiles
{
    public class IM_SortClass_SqlProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<IMSortClass_Sql, IM_SortClassDto>();
            CreateMap<IM_SortClassDto, IMSortClass_Sql>();
        }
    }
}