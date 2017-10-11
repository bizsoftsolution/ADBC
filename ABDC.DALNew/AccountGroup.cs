//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABDC.DALNew
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountGroup()
        {
            this.AccountGroup1 = new HashSet<AccountGroup>();
            this.Ledgers = new HashSet<Ledger>();
        }
    
        public int Id { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> UnderGroupId { get; set; }
        public string GroupCode { get; set; }
        public int FundMasterId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountGroup> AccountGroup1 { get; set; }
        public virtual AccountGroup AccountGroup2 { get; set; }
        public virtual FundMaster FundMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers { get; set; }
    }
}
