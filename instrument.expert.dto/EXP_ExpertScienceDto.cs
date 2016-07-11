/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：6e21d322-7af3-4e73-9518-4182a2ae8b05
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.dto
 * 类名称：EXP_ExpertScienceDto
 * 文件名：EXP_ExpertScienceDto
 * 创建年份：2016
 * 创建时间：2016/3/31 14:15:35
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.ComponentModel.DataAnnotations;

namespace instrument.expert.dto
{
    public class EXP_ExpertScienceDto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "不能为空！")]
        public string expertid { get; set; }

        public string ins1_cls1 { get; set; }
        public string ins1_cls2 { get; set; }
        public string ins1_cls3 { get; set; }
        public string ins2_cls1 { get; set; }
        public string ins2_cls2 { get; set; }
        public string ins2_cls3 { get; set; }
        public string ins3_cls1 { get; set; }
        public string ins3_cls2 { get; set; }
        public string ins3_cls3 { get; set; }
        public string dom1_cls1 { get; set; }
        public string dom1_cls2 { get; set; }
        public string dom1_cls3 { get; set; }
        public string dom2_cls1 { get; set; }
        public string dom2_cls2 { get; set; }
        public string dom2_cls3 { get; set; }
        public string dom3_cls1 { get; set; }
        public string dom3_cls2 { get; set; }
        public string dom3_cls3 { get; set; }
        public int? side_yj { get; set; }
        public int? side_rj { get; set; }
        public int? side_yy { get; set; }
        public int? side_cz { get; set; }
        public int? side_sjcl { get; set; }
        public int? side_scfx { get; set; }
        public int? side_qt { get; set; }
        public string side_qt_des { get; set; }
        public int? language { get; set; }
        public int? languagelevel { get; set; }
        public int? itlevel { get; set; }
        public int? training { get; set; }
        public int? firm_familiarity { get; set; }
        public int? gov_familiarity { get; set; }
    }
}