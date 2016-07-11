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
 * 唯一标识：fb276560-844b-4e61-ac00-3f314425b3b6
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：SampleClassBll
 * 文件名：SampleClassBll
 * 创建年份：2016
 * 创建时间：2016/4/5 16:28:19
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.bll.Impl
{
    public class SampleClassBll : ISampleClassBll
    {
        private readonly ISampleClassRepository _repository;

        public SampleClassBll(ISampleClassRepository repository)
        {
            _repository = repository;
        }

        public IList<Sample_ClassDto> GetSampleClsListByID(string id)
        {
            var list = _repository.GetByWhere(m => m.Sample_ClassID.Contains(id));
            return Mapper.Map<IList<Sample_ClassDto>>(list);
        }
    }
}