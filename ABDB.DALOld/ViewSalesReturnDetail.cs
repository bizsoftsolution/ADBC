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
    
    public partial class ViewSalesReturnDetail
    {
        public decimal SRDId { get; set; }
        public decimal SalesId { get; set; }
        public string ItemName { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Amount { get; set; }
        public string UOM { get; set; }
        public double TaxPer { get; set; }
        public Nullable<double> TaxAmt { get; set; }
        public Nullable<double> DisPer { get; set; }
        public Nullable<double> DisAmt { get; set; }
        public Nullable<double> TotalAmt { get; set; }
        public string RootGroup { get; set; }
    }
}
