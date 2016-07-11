using instrument.expert.model;

namespace instrument.expert.repository
{
    public interface IExpertCommentRepository : IRepository<EXP_Comment>
    {
        bool Exist(string eid);
    }
}