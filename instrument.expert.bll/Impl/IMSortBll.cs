/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：497ba415-73f6-4131-b34e-213c7ba55140
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：IMSortBll
 * 文件名：IMSortBll
 * 创建年份：2016
 * 创建时间：2016/4/1 11:57:35
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
    public class IMSortBll : IIMSortBll
    {
        private readonly IIMSortRepository _repository;

        public IMSortBll(IIMSortRepository repository)
        {
            _repository = repository;
        }

        public IList<IM_SortDto> GetListByMID(string mid)
        {
            var list = _repository.GetByWhere(m => m.IMMSortID == mid);
            return Mapper.Map<IList<IM_SortDto>>(list);
        }
    }
}