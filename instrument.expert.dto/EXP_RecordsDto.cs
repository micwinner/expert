/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：00b58c3a-7012-4061-b14d-b0b4234f0ce6
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.dto
 * 类名称：EXP_RecordsDto
 * 文件名：EXP_RecordsDto
 * 创建年份：2016
 * 创建时间：2016/4/11 16:54:32
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System;
using System.ComponentModel.DataAnnotations;

namespace instrument.expert.dto
{
    public class EXP_RecordsDto
    {
        [Key]
        public int ID { get; set; }

        public string expertid { get; set; }
        public int? progromid { get; set; }
        public int? actionid { get; set; }
        public string actiontitle { get; set; }
        public DateTime? actionstartdate { get; set; }
        public DateTime? actionenddate { get; set; }
        public string inviter { get; set; }
        public string follow { get; set; }
        public decimal? reward { get; set; }
        public decimal? income { get; set; }
        public int? tickling { get; set; }
    }
}