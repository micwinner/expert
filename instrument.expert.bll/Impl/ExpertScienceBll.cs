/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：017a8b26-cac8-4a23-bf7e-d39f38d027bd
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：ExpertScienceBll
 * 文件名：ExpertScienceBll
 * 创建年份：2016
 * 创建时间：2016/4/8 16:02:29
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System;
using System.Collections.Generic;
using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;
using instrument.expert.repository;

namespace instrument.expert.bll.Impl
{
    public class ExpertScienceBll : IExpertScienceBll
    {
        private readonly IExpertScienceRepository _repository;

        public ExpertScienceBll(IExpertScienceRepository repository)
        {
            _repository = repository;
        }

        public int Insert(EXP_ExpertScienceDto dto)
        {
            return _repository.Insert(Mapper.Map<EXP_ExpertScience>(dto));
        }

        public IList<EXP_ExpertScienceDto> GetList()
        {
            throw new NotImplementedException();
        }

        public EXP_ExpertScienceDto GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string eid)
        {
            return _repository.Exist(eid);
        }
    }
}