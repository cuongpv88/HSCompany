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
    
    public partial class Sys_Department
    {
        public string DepartmentID { get; set; }
        public string Department_Name { get; set; }
        public Nullable<int> Department_Sequence { get; set; }
        public string Department_Respon { get; set; }
        public string Department_Code { get; set; }
        public string Department_ParentCode { get; set; }
        public Nullable<int> Department_Level { get; set; }
        public string Department_IsDel { get; set; }
        public System.DateTime Department_AddTime { get; set; }
        public string Department_AddUserID { get; set; }
        public string Department_Type { get; set; }
    }
}