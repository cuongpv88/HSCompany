//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shu.Model
{
    
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Sys_Log
    {
        public string SysLogID { get; set; }
        public string SysLog_OperateDep { get; set; }
        public string SysLog_TableName { get; set; }
        public string SysLog_OperateFunName { get; set; }
        public string SysLog_OperateDataID { get; set; }
        public string SysLog_OperateUserID { get; set; }
        public string SysLog_OperateType { get; set; }
        public string SysLog_Remark { get; set; }
        public Nullable<System.DateTime> SysLog_OperateDate { get; set; }
        public string SysLog_Ip { get; set; }
    }
}
