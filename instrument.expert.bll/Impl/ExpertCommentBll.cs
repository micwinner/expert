/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：b3c6be97-ac3a-4dbe-ad08-b42d9eac461d
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.bll.Impl
 * 类名称：ExpertCommentBll
 * 文件名：ExpertCommentBll
 * 创建年份：2016
 * 创建时间：2016/4/11 10:56:16
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
    public class ExpertCommentBll : IExpertCommentBll
    {
        private readonly IExpertCommentRepository _repository;

        public ExpertCommentBll(IExpertCommentRepository repository)
        {
            _repository = repository;
        }

        public int Insert(EXP_CommentDto dto)
        {
            return _repository.Insert(Mapper.Map<EXP_Comment>(dto));
        }

        public IList<EXP_CommentDto> GetList()
        {
            return null;
        }

        public EXP_CommentDto GetByID(int id)
        {
            return Mapper.Map<EXP_CommentDto>(_repository.GetByKey(id));
        }

        public bool Exist(string eid)
        {
            return _repository.Exist(eid);
        }
    }
}