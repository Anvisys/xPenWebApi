//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string ActivityDescription { get; set; }
        public System.DateTime CreationDate { get; set; }
        public bool SelectedRow { get; set; }
        public int OrgID { get; set; }
        public Nullable<int> ApproverID { get; set; }
    }
}