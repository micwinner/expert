/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：4183aa0e-f061-4568-bea4-5a5010d0f436
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：SampleBll
 * 文件名：SampleBll
 * 创建年份：2016
 * 创建时间：2016/4/5 15:27:08
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
    public class SampleBll : ISampleBll
    {
        private readonly ISampleRepository _repository;

        public SampleBll(ISampleRepository repository)
        {
            _repository = repository;
        }

        public IList<SampleDto> GetList()
        {
            var list = _repository.GetByWhere(m => !string.IsNullOrEmpty(m.SampleID));
            return Mapper.Map<IList<SampleDto>>(list);
        }
    }
}