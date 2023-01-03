//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Order
    {
        public int Id { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Cpu_Id { get; set; }
        public Nullable<int> MotherBoard_Id { get; set; }
        public Nullable<int> Ram_Id { get; set; }
        public Nullable<int> Powersup_Id { get; set; }
        public Nullable<int> GPU_Id { get; set; }
        public Nullable<int> Case_Id { get; set; }
        public Nullable<int> Keyboard_Id { get; set; }
        public Nullable<int> Mouse_Id { get; set; }
        public Nullable<int> Screen_Id { get; set; }
        public Nullable<decimal> Total_Price { get; set; }
        public Nullable<int> Kulaklık_Id { get; set; }
        public Nullable<int> Disk_Id { get; set; }
    
        public virtual tbl_CPU tbl_CPU { get; set; }
        public virtual tbl_Customer tbl_Customer { get; set; }
        public virtual tbl_Disk tbl_Disk { get; set; }
        public virtual tbl_Ekran tbl_Ekran { get; set; }
        public virtual tbl_GPU tbl_GPU { get; set; }
        public virtual tbl_kasa tbl_kasa { get; set; }
        public virtual tbl_Keyboard tbl_Keyboard { get; set; }
        public virtual tbl_Kulaklık tbl_Kulaklık { get; set; }
        public virtual tbl_MotherBoard tbl_MotherBoard { get; set; }
        public virtual tbl_mouse tbl_mouse { get; set; }
        public virtual tbl_PSU tbl_PSU { get; set; }
        public virtual tbl_RAM tbl_RAM { get; set; }
    }
}