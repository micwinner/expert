using instrument.expert.model;

namespace instrument.expert.repository
{
    public interface IExpertScienceRepository : IRepository<EXP_ExpertScience>
    {
        bool Exist(string eid);
    }
}