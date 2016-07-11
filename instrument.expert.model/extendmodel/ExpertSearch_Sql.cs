/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：7328893e-c0c9-43f6-850d-a8862be5b7bf
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.model
 * 类名称：ExpertSearch_Sql
 * 文件名：ExpertSearch_Sql
 * 创建年份：2016
 * 创建时间：2016/4/18 13:50:59
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System;

namespace instrument.expert.model.extendmodel
{
    public class ExpertSearch_Sql
    {
        public int id { get; set; }
        public string expertid { get; set; }
        public string name { get; set; }
        public string exptype { get; set; }
        public string ins_cls { get; set; }
        public string dom_cls { get; set; }
        public string address { get; set; }
        public string unitname { get; set; }
    }
}