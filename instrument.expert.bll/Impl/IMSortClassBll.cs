/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：f759dc78-e830-4547-9eda-54d7bc005195
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：IMSortClassBll
 * 文件名：IMSortClassBll
 * 创建年份：2016
 * 创建时间：2016/4/1 15:08:33
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
    public class IMSortClassBll : IIMSortClassBll
    {
        private readonly IIMSortClassRepository _repository;

        public IMSortClassBll(IIMSortClassRepository repository)
        {
            _repository = repository;
        }

        public IList<IM_SortClassDto> GetCls3ListByID(string id)
        {
            var list = _repository.GetByWhere(m => m.IMSortType == id);
            return Mapper.Map<IList<IM_SortClassDto>>(list);
        }

        public IList<IM_SortClassDto> GetCls3ListByID_Sql(string id)
        {
            var list = _repository.GetListBySql(id);
            return Mapper.Map<IList<IM_SortClassDto>>(list);
        }
    }
}