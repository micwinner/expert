using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface ISampleBll
    {
        IList<SampleDto> GetList();
    }
}