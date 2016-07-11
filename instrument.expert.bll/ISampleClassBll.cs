using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface ISampleClassBll
    {
        IList<Sample_ClassDto> GetSampleClsListByID(string id);
    }
}