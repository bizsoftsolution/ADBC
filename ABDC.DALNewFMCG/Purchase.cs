//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABDB.DALNewFMCG
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
        }
    
        public long Id { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public string RefNo { get; set; }
        public string RefCode { get; set; }
        public int LedgerId { get; set; }
        public int TransactionTypeId { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string BankName { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal GSTAmount { get; set; }
        public decimal ExtraAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Narration { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string BankName { get; set; }
    
        public virtual Ledger Ledger { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
