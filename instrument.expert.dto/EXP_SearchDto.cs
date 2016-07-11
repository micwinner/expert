/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：06fdd7d9-1a06-462c-adad-968d6bf7b2b8
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.dto
 * 类名称：EXP_SearchDto
 * 文件名：EXP_SearchDto
 * 创建年份：2016
 * 创建时间：2016/4/18 13:49:41
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System;

namespace instrument.expert.dto
{
    public class EXP_SearchDto
    {
        public int ID { get; set; }
        public string ExpertID { get; set; }
        public string Name { get; set; }
        public string VipAccount { get; set; }
        public string ExpType { get; set; }
        public string Ins_Cls { get; set; }
        public string Dom_Cls { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Unit { get; set; }
        public string ProAction { get; set; }
        public string ActScore { get; set; }
        public int IsLively { get; set; }
        public DateTime CreateDate { get; set; }
    }
}