using System.Configuration;

namespace instrument.expert.web.Helpers
{
    public class WebApiUrl
    {
        private static readonly string BaseUrl = ConfigurationManager.AppSettings["webApiBaseUrl"];
        public static string LoginUrl = BaseUrl + "/api/imaminduser";
        public static string LoginOutUrl = BaseUrl + "/api/imaminduser/loginout";
        //添加Expert接口 post
        public static string ExpertAddUrl = BaseUrl + "/api/expert/InsertExpert";
        //检查ExpertID接口 get
        public static string ExpertExistUrl = BaseUrl + "/api/expert/check/";
        //添加ExpertScience接口 post
        public static string ExpertScienceAddUrl = BaseUrl + "/api/expertscience";
        //检查ExpertScience接口 get
        public static string ExpertScienceExistUrl = BaseUrl + "/api/expertscience/check/";
        //添加ExpertComment接口 post
        public static string ExpertCommentAddUrl = BaseUrl + "/api/expertcomment";
        //检查ExpertComment接口 get
        public static string ExpertCommentExistUrl = BaseUrl + "/api/expertcomment/check/";
        //分页获得某个专家的所有合作记录
        public static string GetRecordsListUrl = BaseUrl + "/api/expertrecords/records?id={0}&page={1}&pagesize={2}";
        //获得单条合作记录信息
        public static string GetRecordsOneUrl = BaseUrl + "/api/expertrecords/records/";
        //更新合作记录修改
        public static string SaveRecordsUrl = BaseUrl + "/api/expertrecords";
        //添加合作记录
        public static string AddRecordsUrl = BaseUrl + "/api/expertrecords";
        //删除合作记录
        public static string DeleteRecordsUrl = BaseUrl + "/api/expertrecords/delete/{0}";
        public static string CountryUrl = BaseUrl + "/api/vipzonecountry";
        public static string ProvinceUrl = BaseUrl + "/api/vipzoneprovince/getlistbycid/";
        public static string CityUrl = BaseUrl + "/api/vipzonecity/getlistbypid/";
        public static string IMSortMainUrl = BaseUrl + "/api/imsortmain";
        public static string IMSortUrl = BaseUrl + "/api/imsort/getlistbymid/";
        public static string IMSortClassUrl = BaseUrl + "/api/imsortclass/getcls3listbyid/";
        public static string IMSortClassUrl2 = BaseUrl + "/api/imsortclass/getcls3listbyid_sql/";
        public static string SampleUrl = BaseUrl + "/api/sample/getsamplelist";
        public static string SampleClassUrl = BaseUrl + "/api/sampleclass/getsampleclslist/";
        public static string SampleSortUrl = BaseUrl + "/api/samplesort/getsamplesortlist/";
    }
}