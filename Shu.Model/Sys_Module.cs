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
    
    public partial class Sys_Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Module()
        {
            this.Sys_Menu = new HashSet<Sys_Menu>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public string Content { get; set; }
        public bool IsAccredit { get; set; }
        public bool IsShow { get; set; }
        public System.DateTime AddTime { get; set; }
        public string AddUserId { get; set; }
        public string EditUserId { get; set; }
        public Nullable<System.DateTime> EditTime { get; set; }
        public bool IsDelete { get; set; }
        public int Sort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[JsonIgnore]
        public virtual ICollection<Sys_Menu> Sys_Menu { get; set; }
    }
}
