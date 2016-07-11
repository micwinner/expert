using instrument.expert.model;
using instrument.expert.model.extendmodel;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace instrument.expert.repository
{
    public interface IExpertRepository : IRepository<EXP_Expert>
    {
        bool Exist(string eid);
        IList<ExpertSearch_Sql> GetListByWhere(ExpertSearchWhere where);
    }
}