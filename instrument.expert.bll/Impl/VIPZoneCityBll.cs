using System.Collections.Generic;
using AutoMapper;
using instrument.expert.dto;
using instrument.expert.repository;

/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：c892e973-47ff-4edd-910e-c9a6d20fe2be
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll
 * 类名称：IVIPZoneCityBll
 * 文件名：IVIPZoneCityBll
 * 创建年份：2016
 * 创建时间：2016/3/29 18:23:28
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.bll.Impl
{
    public class VIPZoneCityBll : IVIPZoneCityBll
    {
        private readonly IVIPZoneCityRepository _repository;

        public VIPZoneCityBll(IVIPZoneCityRepository repository)
        {
            _repository = repository;
        }

        public IList<VIPZone_CityDto> GetCityListByID(int id)
        {
            var list = _repository.GetByWhere(m => m.PR_ID == id);
            return Mapper.Map<IList<VIPZone_CityDto>>(list);
        }
    }
}