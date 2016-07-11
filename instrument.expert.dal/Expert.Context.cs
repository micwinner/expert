using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using instrument.expert.model;

namespace instrument.expert.dal
{
    public class instrumentEntities : DbContext
    {
        public instrumentEntities()
            : base("name=instrumentEntities")
        {
        }

        public DbSet<EXP_Expert> EXP_Expert { get; set; }
        public DbSet<EXP_Comment> EXP_Comment { get; set; }
        public DbSet<EXP_ExpertScience> EXP_ExpertScience { get; set; }
        public DbSet<IM_Admin_User> IM_Admin_User { get; set; }
        public DbSet<IM_SortMain> IM_SortMain { get; set; }
        public DbSet<IM_SortClass> IM_SortClass { get; set; }
        public DbSet<IM_Sort> IM_Sort { get; set; }
        public DbSet<VIPZone_City> VIPZone_City { get; set; }
        public DbSet<VIPZone_Country> VIPZone_Country { get; set; }
        public DbSet<VIPZone_Province> VIPZone_Province { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<Sample_Class> Sample_Class { get; set; }
        public DbSet<Sample_Sort> Sample_Sort { get; set; }
        public DbSet<EXP_Records> EXP_Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    }
}