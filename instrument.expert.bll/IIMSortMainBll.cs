using System.Collections.Generic;
using instrument.expert.dto;

namespace instrument.expert.bll
{
    public interface IIMSortMainBll
    {
        IList<IM_SortMainDto> GetAllImSortMainDtos();
    }
}