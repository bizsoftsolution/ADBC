﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nubebfsv1Entities : DbContext
    {
        public nubebfsv1Entities()
            : base("name=nubebfsv1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountGroup> AccountGroups { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<JournalDetail> JournalDetails { get; set; }
        public virtual DbSet<JournalMaster> JournalMasters { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<LedgerOP> LedgerOPs { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<PaymentMaster> PaymentMasters { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<ReceiptMaster> ReceiptMasters { get; set; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public virtual DbSet<FeesDetail> FeesDetails { get; set; }
        public virtual DbSet<FeesMaster> FeesMasters { get; set; }
        public virtual DbSet<LedgerReport> LedgerReports { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public virtual DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesDetail> SalesDetails { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesReturn> SalesReturns { get; set; }
        public virtual DbSet<SalesReturnDetail> SalesReturnDetails { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StockGroup> StockGroups { get; set; }
        public virtual DbSet<StockReport> StockReports { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TaxMaster> TaxMasters { get; set; }
        public virtual DbSet<USERMASTER> USERMASTERs { get; set; }
        public virtual DbSet<ViewAnnualStatement> ViewAnnualStatements { get; set; }
        public virtual DbSet<ViewBankBranchAdvice> ViewBankBranchAdvices { get; set; }
        public virtual DbSet<ViewBranchMonthlyStatement> ViewBranchMonthlyStatements { get; set; }
        public virtual DbSet<ViewLedger> ViewLedgers { get; set; }
        public virtual DbSet<ViewLedgerGroup> ViewLedgerGroups { get; set; }
        public virtual DbSet<ViewLedgerJournal> ViewLedgerJournals { get; set; }
        public virtual DbSet<ViewLedgerOpening> ViewLedgerOpenings { get; set; }
        public virtual DbSet<ViewLedgerPayment> ViewLedgerPayments { get; set; }
        public virtual DbSet<ViewLedgerPurchase> ViewLedgerPurchases { get; set; }
        public virtual DbSet<ViewLedgerReceipt> ViewLedgerReceipts { get; set; }
        public virtual DbSet<ViewLedgerReport> ViewLedgerReports { get; set; }
        public virtual DbSet<ViewMasterMember> ViewMasterMembers { get; set; }
        public virtual DbSet<ViewMemberLastPaidDate> ViewMemberLastPaidDates { get; set; }
        public virtual DbSet<ViewPurchase> ViewPurchases { get; set; }
        public virtual DbSet<ViewPurchaseDetail> ViewPurchaseDetails { get; set; }
        public virtual DbSet<ViewPurchaseOrder> ViewPurchaseOrders { get; set; }
        public virtual DbSet<ViewPurchaseOrderDetail> ViewPurchaseOrderDetails { get; set; }
        public virtual DbSet<ViewPurchaseReturn> ViewPurchaseReturns { get; set; }
        public virtual DbSet<ViewPurchaseReturnDetail> ViewPurchaseReturnDetails { get; set; }
        public virtual DbSet<ViewPurchaseSearch> ViewPurchaseSearches { get; set; }
        public virtual DbSet<ViewReceipt> ViewReceipts { get; set; }
        public virtual DbSet<ViewSale> ViewSales { get; set; }
        public virtual DbSet<ViewSalesDetail> ViewSalesDetails { get; set; }
        public virtual DbSet<ViewSalesOrder> ViewSalesOrders { get; set; }
        public virtual DbSet<ViewSalesOrderDetail> ViewSalesOrderDetails { get; set; }
        public virtual DbSet<ViewSalesReturn> ViewSalesReturns { get; set; }
        public virtual DbSet<ViewSalesReturnDetail> ViewSalesReturnDetails { get; set; }
        public virtual DbSet<ViewStockGroup> ViewStockGroups { get; set; }
        public virtual DbSet<ViewStockReport> ViewStockReports { get; set; }
        public virtual DbSet<ViewTrialBalance> ViewTrialBalances { get; set; }
    }
}
