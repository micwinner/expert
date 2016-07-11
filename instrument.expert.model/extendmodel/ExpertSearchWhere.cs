/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：7110eb3f-7aa6-4775-8eaf-ecd2e0712886
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.model.extendmodels
 * 类名称：ExpertSearchWhere
 * 文件名：ExpertSearchWhere
 * 创建年份：2016
 * 创建时间：2016/4/18 18:29:23
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrument.expert.model.extendmodel
{
    public class ExpertSearchWhere
    {
        public string name { get; set; }
        public string vipaccount { get; set; }
        public string anthor { get; set; }
        public DateTime? indate { get; set; }
        public int? exptype { get; set; }
        public string ins_cls { get; set; }
        public string dom_cls { get; set; }
        public int? country { get; set; }
        public int? province { get; set; }
        public int? city { get; set; }
        public string phone { get; set; }
        public int? progromid { get; set; }
        public int? actionid { get; set; }
        public DateTime? actiondate { get; set; }
        public double? actionscore { get; set; }
        public string contacts { get; set; }
    }
}
