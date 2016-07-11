using AutoMapper;
using instrument.expert.mapper.Profiles;

namespace instrument.expert.mapper
{
    public static class AutoMapperConfig
    {
        public static void Configuration()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ExpertProfile>();
                cfg.AddProfile<CommentProfile>();
                cfg.AddProfile<ExpertScienceProfile>();
                cfg.AddProfile<IMAdminUserProfile>();
                cfg.AddProfile<IM_SortMainProfile>();
                cfg.AddProfile<IM_SortClassProfile>();
                cfg.AddProfile<IM_SortClass_SqlProfile>();
                cfg.AddProfile<IM_SortProfile>();
                cfg.AddProfile<VIPZone_CityProfile>();
                cfg.AddProfile<VIPZone_CountryProfile>();
                cfg.AddProfile<VIPZone_ProvinceProfile>();
                cfg.AddProfile<SampleProfile>();
                cfg.AddProfile<Sample_ClassProfile>();
                cfg.AddProfile<Sample_SortProfile>();
                cfg.AddProfile<ExpertRecordsProfile>();
                cfg.AddProfile<ExpertSearchProfile>();
                cfg.AddProfile<ExpertSearchWhereProfile>();
            });
        }
    }
}