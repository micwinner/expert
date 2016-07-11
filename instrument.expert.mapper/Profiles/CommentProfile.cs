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
 * 唯一标识：cd5cabb8-60cb-48ea-b7dd-f72df7c6259e
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：CommentProfile
 * 文件名：CommentProfile
 * 创建年份：2016
 * 创建时间：2016/3/31 14:29:12
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.mapper.Profiles
{
    public class CommentProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<EXP_Comment, EXP_CommentDto>();
            CreateMap<EXP_CommentDto, EXP_Comment>();
        }
    }
}