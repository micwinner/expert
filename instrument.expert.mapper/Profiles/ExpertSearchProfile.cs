using AutoMapper;
/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：052851c5-1b47-47e5-8029-fb8d71c45858
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.mapper.Profiles
 * 类名称：ExpertSearchProfile
 * 文件名：ExpertSearchProfile
 * 创建年份：2016
 * 创建时间：2016/4/18 19:28:07
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using instrument.expert.dto;
using instrument.expert.model.extendmodel;

namespace instrument.expert.mapper.Profiles
{
    public class ExpertSearchProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<EXP_SearchDto, ExpertSearch_Sql>();
            CreateMap<ExpertSearch_Sql, EXP_SearchDto>();
        }
    }
}
