//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABDC.DALNewNUBE
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaxMaster
    {
        public int Id { get; set; }
        public string TaxName { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
        public Nullable<int> CompanyId { get; set; }
    
        public virtual CompanyDetail CompanyDetail { get; set; }
    }
}
