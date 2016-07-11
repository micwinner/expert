using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IExpertScienceBll
    {
        int Insert(EXP_ExpertScienceDto dto);
        IList<EXP_ExpertScienceDto> GetList();
        EXP_ExpertScienceDto GetByID(int id);
        bool Exist(string eid);
    }
}