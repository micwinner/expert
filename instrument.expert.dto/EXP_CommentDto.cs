/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：d7868861-7102-4b01-a1af-4893d033d7c0
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.dto
 * 类名称：EXP_CommentDto
 * 文件名：EXP_CommentDto
 * 创建年份：2016
 * 创建时间：2016/3/31 14:15:02
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

namespace instrument.expert.dto
{
    public class EXP_CommentDto
    {
        public int id { get; set; }
        public string expertid { get; set; }
        public int? publicity { get; set; }
        public int? familiarity { get; set; }
        public int? character { get; set; }
        public int? mandarinlevel { get; set; }
        public int? tickling { get; set; }
        public int? cooperative1 { get; set; }
        public int? cooperative2 { get; set; }
        public int? works_zlfy { get; set; }
        public int? works_zxgj { get; set; }
        public int? works_pxzj { get; set; }
        public int? works_hdjb { get; set; }
        public int? works_zx { get; set; }
        public int? works_qt { get; set; }
        public string recommend { get; set; }
    }
}