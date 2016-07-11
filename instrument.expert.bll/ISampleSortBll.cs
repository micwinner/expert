using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface ISampleSortBll
    {
        IList<Sample_SortDto> GetSampleSortListByID(string id);
    }
}