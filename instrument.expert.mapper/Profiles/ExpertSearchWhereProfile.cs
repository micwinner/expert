using AutoMapper;
/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：e2341ff0-1a39-4a89-a193-e7729f73f6b1
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：ExpertSearchWhereProfile
 * 文件名：ExpertSearchWhereProfile
 * 创建年份：2016
 * 创建时间：2016/4/18 19:30:58
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/
using instrument.expert.model.extendmodel;
using instrument.expert.dto;

namespace instrument.expert.mapper.Profiles
{
    public class ExpertSearchWhereProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ExpertSearchWhere, EXP_SearchWhereDto>();
            CreateMap<EXP_SearchWhereDto, ExpertSearchWhere>();
        }
    }
}
