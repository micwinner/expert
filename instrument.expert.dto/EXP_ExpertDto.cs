using System;
using System.ComponentModel.DataAnnotations;

namespace instrument.expert.dto
{
    public class EXP_ExpertDto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "专家姓名不能为空！")]
        [StringLength(30, ErrorMessage = "最大长度为30！")]
        public string name { get; set; }

        public short? sex { get; set; }
        public DateTime? birthday { get; set; }
        public int? country { get; set; }
        public int? province { get; set; }
        public int? city { get; set; }
        public string address { get; set; }
        public string postcode { get; set; }
        public string officephone { get; set; }
        public string mobilephone { get; set; }
        public string homephone { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public short? exptype { get; set; }
        public short? education { get; set; }
        public short? jobtitle { get; set; }
        public short? jobposition { get; set; }
        public short? jobstatus { get; set; }
        public string unitname { get; set; }
        public short? sparetime { get; set; }
        public string hobbies { get; set; }
        public string resumeurl { get; set; }
        public string remark { get; set; }
        public byte[] rowversion { get; set; }
        public string vipaccount { get; set; }
        public string positions1 { get; set; }
        public string positions2 { get; set; }
        public string positions3 { get; set; }
        public string expertid { get; set; }
    }
}