/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：7c547baa-c8d2-4ed5-a70c-01c090b02f70
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：ExpertRecordsBll
 * 文件名：ExpertRecordsBll
 * 创建年份：2016
 * 创建时间：2016/4/11 17:45:17
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
using instrument.expert.model;
using instrument.expert.repository;

namespace instrument.expert.bll.Impl
{
    public class ExpertRecordsBll : IExpertRecordsBll
    {
        private readonly IExpertRecordsRepository _recordsRepository;

        public ExpertRecordsBll(IExpertRecordsRepository recordsRepository)
        {
            _recordsRepository = recordsRepository;
        }

        public IList<EXP_RecordsDto> GetList(int page, int pagesize, out int count)
        {
            var list = _recordsRepository.GetList(page, pagesize, out count);
            return Mapper.Map<IList<EXP_RecordsDto>>(list);
        }

        public IList<EXP_RecordsDto> GetListByEID(string eid, int page, int pagesize, out int count)
        {
            var list = _recordsRepository.GetListByEID(eid, page, pagesize, out count);
            return Mapper.Map<IList<EXP_RecordsDto>>(list);
        }

        public EXP_RecordsDto GetOne(int id)
        {
            var data = _recordsRepository.GetByKey(id);
            return Mapper.Map<EXP_RecordsDto>(data);
        }

        public int Update(EXP_RecordsDto model)
        {
            var result = _recordsRepository.Update(Mapper.Map<EXP_Records>(model));
            return result;
        }

        public int Add(EXP_RecordsDto model)
        {
            var result = _recordsRepository.Insert(Mapper.Map<EXP_Records>(model));
            return result;
        }

        public int Delete(int id)
        {
            var result = _recordsRepository.Delete(id);
            return result;
        }
    }
}