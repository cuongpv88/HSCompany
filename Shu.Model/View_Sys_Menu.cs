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
    
    public partial class View_Sys_Menu
    {
        public string MenuID { get; set; }
        public string Menu_Name { get; set; }
        public string Menu_Description { get; set; }
        public int Menu_Sequence { get; set; }
        public string Menu_Url { get; set; }
        public int Menu_Level { get; set; }
        public string Menu_Code { get; set; }
        public string Menu_ParentCode { get; set; }
        public Nullable<System.DateTime> Menu_AddTime { get; set; }
        public string Menu_AddUserID { get; set; }
        public string Menu_Operation { get; set; }
    }
}
