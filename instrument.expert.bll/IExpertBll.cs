using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IExpertBll
    {
        int Insert(EXP_ExpertDto dto);
        IList<EXP_ExpertDto> GetList();
        EXP_ExpertDto GetByID(int id);
        bool Exist(string eid);
        IList<EXP_SearchDto> GetSearch(EXP_SearchWhereDto where); 
    }
}