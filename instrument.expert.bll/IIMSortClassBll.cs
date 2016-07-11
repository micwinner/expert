using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IIMSortClassBll
    {
        IList<IM_SortClassDto> GetCls3ListByID(string id);
        IList<IM_SortClassDto> GetCls3ListByID_Sql(string id);
    }
}