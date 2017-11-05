//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABDC.DALOldNUBE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ledger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ledger()
        {
            this.JournalDetails = new HashSet<JournalDetail>();
            this.LedgerOPs = new HashSet<LedgerOP>();
            this.PaymentDetails = new HashSet<PaymentDetail>();
            this.PaymentMasters = new HashSet<PaymentMaster>();
            this.ReceiptDetails = new HashSet<ReceiptDetail>();
            this.ReceiptMasters = new HashSet<ReceiptMaster>();
        }
    
        public decimal LedgerId { get; set; }
        public string LedgerName { get; set; }
        public string BillingName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string MailId { get; set; }
        public string CreditDays { get; set; }
        public string CreditLimit { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> AccountGroupId { get; set; }
        public string AccountCode { get; set; }
        public Nullable<double> CrAmt { get; set; }
        public Nullable<double> DrAmt { get; set; }
    
        public virtual AccountGroup AccountGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalDetail> JournalDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerOP> LedgerOPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentMaster> PaymentMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptMaster> ReceiptMasters { get; set; }
    }
}
