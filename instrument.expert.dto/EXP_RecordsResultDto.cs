﻿/*******************************************************************
 * 本代码版权归仪器信息网所有，All Rights Reserved (C) 2016-2066
 * 注：修改必须添加修改描述！！！
 *******************************************************************
 * 所属域：INS
 * 登录用户：guoxl
 * CLR版本：4.0.30319.18063
 * 唯一标识：c99432d2-495d-4392-b48a-cdb2b58dffad
 * 机器名称：GUOXL-PC
 *******************************************************************
 * 命名空间：instrument.expert.dto
 * 类名称：EXP_RecordsResult
 * 文件名：EXP_RecordsResult
 * 创建年份：2016
 * 创建时间：2016/4/11 18:04:52
 * 创建人：
 * 创建说明：
 *******************************************************************
 * 修改人：
 * 修改时间：
 * 修改说明：
 *******************************************************************/

using System.Collections.Generic;

namespace instrument.expert.dto
{
    public class EXP_RecordsResultDto
    {
        public IList<EXP_RecordsDto> List { get; set; }
        public int Count { get; set; }
    }
}