//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BIITHRMSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int f_id { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> j_id { get; set; }
        public string Marks { get; set; }
        public string Comment { get; set; }
    
        public virtual Job Job { get; set; }
    }
}