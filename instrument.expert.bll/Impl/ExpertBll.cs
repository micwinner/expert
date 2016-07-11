using System.Collections.Generic;
using AutoMapper;
using instrument.expert.dto;
using instrument.expert.model;
using instrument.expert.model.extendmodel;
using instrument.expert.repository;

namespace instrument.expert.bll.Impl
{
    public class ExpertBll : IExpertBll
    {
        private readonly IExpertRepository _repository;

        public ExpertBll(IExpertRepository repository)
        {
            _repository = repository;
        }

        public int Insert(EXP_ExpertDto dto)
        {
            return _repository.Insert(Mapper.Map<EXP_Expert>(dto));
        }

        public IList<EXP_ExpertDto> GetList()
        {
            var list = _repository.GetByWhere(mode => mode.address == "test");
            return Mapper.Map<IList<EXP_Expert>, IList<EXP_ExpertDto>>(list);
        }

        public EXP_ExpertDto GetByID(int id)
        {
            return Mapper.Map<EXP_ExpertDto>(_repository.GetByKey(id));
        }

        public bool Exist(string eid)
        {
            return _repository.Exist(eid);
        }

        public IList<EXP_SearchDto> GetSearch(EXP_SearchWhereDto where)
        {
            var newWhere = Mapper.Map<ExpertSearchWhere>(where);
            var value = _repository.GetListByWhere(newWhere);
            return Mapper.Map<IList<EXP_SearchDto>>(value);
        }
    }
}