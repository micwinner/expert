/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：57b3d926-9789-4f1b-9ac7-cbd60bf0996d
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：SampleSortBll
 * 文件名：SampleSortBll
 * 创建年份：2016
 * 创建时间：2016/4/5 16:38:28
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
    public class SampleSortBll : ISampleSortBll
    {
        private readonly ISampleSortRepository _repository;

        public SampleSortBll(ISampleSortRepository repository)
        {
            _repository = repository;
        }

        public IList<Sample_SortDto> GetSampleSortListByID(string id)
        {
            var list = _repository.GetByWhere(m => m.Sample_SortID.Contains(id));
            return Mapper.Map<IList<Sample_SortDto>>(list);
        }
    }
}