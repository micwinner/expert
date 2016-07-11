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
 * 唯一标识：6c626c95-1e27-4e0d-ad6a-61cf1dacf937
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：SampleProfile
 * 文件名：SampleProfile
 * 创建年份：2016
 * 创建时间：2016/3/31 14:32:20
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.mapper.Profiles
{
    public class SampleProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Sample, SampleDto>();
            CreateMap<SampleDto, Sample>();
        }
    }
}