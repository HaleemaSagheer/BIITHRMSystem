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
    
    public partial class user1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user1()
        {
            this.Educations = new HashSet<Education>();
            this.Experiences = new HashSet<Experience>();
        }
    
        public int Uid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string cnic { get; set; }
        public System.DateTime dob { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    
        public virtual Apply Apply { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Education> Educations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
