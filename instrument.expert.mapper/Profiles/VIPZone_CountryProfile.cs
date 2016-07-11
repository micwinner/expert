/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：7f917354-262e-4a84-a36a-93a56580286b
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：VIPZone_CountryProfile
 * 文件名：VIPZone_CountryProfile
 * 创建年份：2016
 * 创建时间：2016/3/29 17:55:32
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;

namespace instrument.expert.mapper.Profiles
{
    public class VIPZone_CountryProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<VIPZone_Country, VIPZone_CountryDto>();
            CreateMap<VIPZone_CountryDto, VIPZone_Country>();
        }
    }
}