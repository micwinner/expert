using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IExpertCommentBll
    {
        int Insert(EXP_CommentDto dto);
        IList<EXP_CommentDto> GetList();
        EXP_CommentDto GetByID(int id);
        bool Exist(string eid);
    }
}