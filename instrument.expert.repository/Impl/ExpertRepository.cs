using System.Linq;
using instrument.expert.model;
using System.Collections.Generic;
using System.Data;
using instrument.expert.model.extendmodel;
using System.Data.SqlClient;
using System.Text;

namespace instrument.expert.repository.Impl
{
    public class ExpertRepository : Repository<EXP_Expert>, IExpertRepository
    {
        public bool Exist(string eid)
        {
            return DB.EXP_Expert.FirstOrDefault(m => m.expertid == eid) != null;
        }

        public IList<ExpertSearch_Sql> GetListByWhere(ExpertSearchWhere where)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT e.id,e.expertid,e.name,e.exptype,e.unitname,");
            sql.Append("ISNULL(sm.IMMSortName,'') + '>' + ISNULL(s.IMNote,'') + '>' + ISNULL(sc.IMNote,'') as ins_cls,");
            sql.Append("ISNULL(sp.SampleName,'') + '>' + ISNULL(scls.Sample_ClassName,'') + '>' + ISNULL(sort.Sample_SortName,'') as dom_cls,");
            sql.Append("ISNULL(zc.CO_Name, '') + '>' + ISNULL(zp.PR_Name,'') + '>' + ISNULL(zct.CI_Name,'') as address ");
            sql.Append(" FROM EXP_Expert e ");
            sql.Append(" LEFT JOIN EXP_ExpertScience es ");
            sql.Append(" ON e.expertid = es.expertid ");
            sql.Append(" LEFT JOIN EXP_Comment c ");
            sql.Append(" ON c.expertid = e.expertid ");
            sql.Append(" INNER JOIN VIPZone_Country zc ");
            sql.Append(" ON zc.CO_ID = e.country ");
            sql.Append(" INNER JOIN VIPZone_Province zp ");
            sql.Append(" ON zp.PR_ID = e.province ");
            sql.Append(" INNER JOIN VIPZone_City zct ");
            sql.Append(" ON zct.CI_ID = e.city ");
            sql.Append(" LEFT JOIN IM_SortMain sm ");
            sql.Append(" ON sm.IMMSortID = es.ins1_cls1 ");
            sql.Append(" LEFT JOIN IM_Sort s ");
            sql.Append(" ON s.IMType = es.ins1_cls2 ");
            sql.Append(" LEFT JOIN IM_SortClass sc ");
            sql.Append(" ON sc.IMType = es.ins1_cls3 ");
            sql.Append(" LEFT JOIN Sample sp ");
            sql.Append(" ON sp.SampleID = es.dom1_cls1 ");
            sql.Append(" LEFT JOIN Sample_Class scls ");
            sql.Append(" ON scls.Sample_ClassID = es.dom1_cls2 ");
            sql.Append(" LEFT JOIN Sample_Sort sort ");
            sql.Append(" ON sort.Sample_SortID = es.dom1_cls3 ");
            sql.Append(" where 1 = 1 ");

            var parmsList = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(where.name))
            {
                sql.Append(" and e.name like '%@name%' ");
                parmsList.Add(new SqlParameter("@name", where.name));
            }
            if (!string.IsNullOrEmpty(where.vipaccount))
            {
                sql.Append(" and e.vipaccount like '%@vipaccount%' ");
                parmsList.Add(new SqlParameter("@vipaccount", where.vipaccount));
            }
            if (where.exptype != null && where.exptype >= 0)
            {
                sql.Append(" and e.exptype = @exptype ");
                parmsList.Add(new SqlParameter("@exptype",where.exptype));
            }
            if (!string.IsNullOrEmpty(where.ins_cls))
            {
                sql.Append(" and (es.ins1_cls1 = '@ins_cls' or es.ins2_cls1 = '@ins_cls' or es.ins3_cls1 = '@ins_cls')");
                parmsList.Add(new SqlParameter("@ins_cls", where.ins_cls));
            }
            if (!string.IsNullOrEmpty(where.dom_cls))
            {
                sql.Append(" and (es.dom1_cls1 = '@dom_cls' or dom2_cls1 = '@dom_cls' or es.dom3_cls1 = '@dom_cls')");
                parmsList.Add(new SqlParameter("@dom_cls", where.dom_cls));
            }
            if (where.country != null && where.country >= 0)
            {
                sql.Append(" and e.country = @country ");
                parmsList.Add(new SqlParameter("@country", where.country));
            }
            if (where.province != null && where.province >= 0)
            {
                sql.Append(" and e.province = @province ");
                parmsList.Add(new SqlParameter("@province", where.province));
            }
            if (where.city != null && where.city >= 0)
            {
                sql.Append(" and e.city = @city ");
                parmsList.Add(new SqlParameter("@city", where.city));
            }
            if (!string.IsNullOrEmpty(where.phone))
            {
                sql.Append(" and (e.officephone = '@phone' or e.mobilephone = '@phone' or e.homephone = '@phone') ");
                parmsList.Add(new SqlParameter("@phone", where.phone));
            }
            return DB.Database.SqlQuery<ExpertSearch_Sql>(sql.ToString()).ToList();
        }
    }
}