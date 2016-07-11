/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：87d27952-e268-465c-814d-a32311925db3
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll
 * 类名称：IVIPZoneCountryBll
 * 文件名：IVIPZoneCountryBll
 * 创建年份：2016
 * 创建时间：2016/3/29 18:23:54
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;
using AutoMapper;
using instrument.expert.dto;
using instrument.expert.repository;

namespace instrument.expert.bll.Impl
{
    public class VIPZoneCountryBll : IVIPZoneCountryBll
    {
        private readonly IVIPZoneCountryRepository _repository;

        public VIPZoneCountryBll(IVIPZoneCountryRepository repository)
        {
            _repository = repository;
        }

        public List<VIPZone_CountryDto> GetAllCountry()
        {
            var list = _repository.GetByWhere(m => !string.IsNullOrEmpty(m.CO_Name));
            return Mapper.Map<List<VIPZone_CountryDto>>(list);
        }
    }
}