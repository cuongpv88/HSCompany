﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shu.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShuEntities : DbContext
    {
        public ShuEntities()
            : base("name=ShuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sys_Config> Sys_Config { get; set; }
        public virtual DbSet<Sys_DataDict> Sys_DataDict { get; set; }
        public virtual DbSet<Sys_Department> Sys_Department { get; set; }
        public virtual DbSet<Sys_Holiday> Sys_Holiday { get; set; }
        public virtual DbSet<Sys_Log> Sys_Log { get; set; }
        public virtual DbSet<Sys_Message> Sys_Message { get; set; }
        public virtual DbSet<Sys_Notice> Sys_Notice { get; set; }
        public virtual DbSet<Sys_PendingMatter> Sys_PendingMatter { get; set; }
        public virtual DbSet<Sys_Post> Sys_Post { get; set; }
        public virtual DbSet<Sys_PostChange> Sys_PostChange { get; set; }
        public virtual DbSet<Sys_Role> Sys_Role { get; set; }
        public virtual DbSet<Sys_RolePurview> Sys_RolePurview { get; set; }
        public virtual DbSet<Sys_Setting> Sys_Setting { get; set; }
        public virtual DbSet<Sys_UserChargeDep> Sys_UserChargeDep { get; set; }
        public virtual DbSet<View_Sys_Log> View_Sys_Log { get; set; }
        public virtual DbSet<View_Sys_Menu> View_Sys_Menu { get; set; }
        public virtual DbSet<View_Sys_MenuRelatedRole> View_Sys_MenuRelatedRole { get; set; }
        public virtual DbSet<View_Sys_Post> View_Sys_Post { get; set; }
        public virtual DbSet<View_Sys_RolePurview> View_Sys_RolePurview { get; set; }
        public virtual DbSet<View_Sys_RolePurviewAndMenu> View_Sys_RolePurviewAndMenu { get; set; }
        public virtual DbSet<View_Sys_UserInfo> View_Sys_UserInfo { get; set; }
        public virtual DbSet<Sys_SeeCharge> Sys_SeeCharge { get; set; }
        public virtual DbSet<View_PendingMatterToRolePurview> View_PendingMatterToRolePurview { get; set; }
        public virtual DbSet<Sys_ModelFile> Sys_ModelFile { get; set; }
        public virtual DbSet<Sys_UploadDataType> Sys_UploadDataType { get; set; }
        public virtual DbSet<Sys_Desktop> Sys_Desktop { get; set; }
        public virtual DbSet<View_Sys_DeskTtop> View_Sys_DeskTtop { get; set; }
        public virtual DbSet<Sys_UserInfo> Sys_UserInfo { get; set; }
        public virtual DbSet<Sys_Area> Sys_Area { get; set; }
        public virtual DbSet<Sys_Menu> Sys_Menu { get; set; }
        public virtual DbSet<Sys_Module> Sys_Module { get; set; }
    }
}
