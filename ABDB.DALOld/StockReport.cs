//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABDC.DALOld
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockReport
    {
        public decimal StockId { get; set; }
        public string VoucherNo { get; set; }
        public string VoucherType { get; set; }
        public Nullable<System.DateTime> SDate { get; set; }
        public decimal ProductId { get; set; }
        public Nullable<double> Qunatity { get; set; }
        public Nullable<double> Rate { get; set; }
        public decimal UOMId { get; set; }
        public Nullable<double> TaxPercentage { get; set; }
        public string FU1 { get; set; }
        public string FU2 { get; set; }
        public string FU3 { get; set; }
    }
}
