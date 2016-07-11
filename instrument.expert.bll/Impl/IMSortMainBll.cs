/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：4f00212b-a2b9-4afb-90a3-2d16d87d2558
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：IMSortMainBll
 * 文件名：IMSortMainBll
 * 创建年份：2016
 * 创建时间：2016/3/31 15:04:52
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
    public class IMSortMainBll : IIMSortMainBll
    {
        private readonly IIMSortMainRepository _repository;

        public IMSortMainBll(IIMSortMainRepository repository)
        {
            _repository = repository;
        }

        public IList<IM_SortMainDto> GetAllImSortMainDtos()
        {
            var list = _repository.GetByWhere(m => !string.IsNullOrEmpty(m.IMMSortName));
            return Mapper.Map<IList<IM_SortMainDto>>(list);
        }
    }
}