﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GASEntities : DbContext
    {
        public GASEntities()
            : base("name=GASEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdvanceItem> AdvanceItems { get; set; }
        public virtual DbSet<ViewActivityStatu> ViewActivityStatus { get; set; }
        public virtual DbSet<ViewActivitySummary> ViewActivitySummaries { get; set; }
        public virtual DbSet<ViewAdvanceStatu> ViewAdvanceStatus { get; set; }
        public virtual DbSet<ViewAdvanceItemName> ViewAdvanceItemNames { get; set; }
        public virtual DbSet<ViewAdvance> ViewAdvances { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ViewActivity> ViewActivities { get; set; }
        public virtual DbSet<ViewActivityDashboard> ViewActivityDashboards { get; set; }
        public virtual DbSet<ViewActivityName> ViewActivityNames { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<ViewMonthCumulativeExpense> ViewMonthCumulativeExpenses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewOrganization> ViewOrganizations { get; set; }
        public virtual DbSet<ViewProjectExpense> ViewProjectExpenses { get; set; }
        public virtual DbSet<ViewAccount> ViewAccounts { get; set; }
        public virtual DbSet<ViewTransactionDailyAccountBalance> ViewTransactionDailyAccountBalances { get; set; }
        public virtual DbSet<ViewTransactionDailyAccount> ViewTransactionDailyAccounts { get; set; }
        public virtual DbSet<ViewTransactionDailySummary> ViewTransactionDailySummaries { get; set; }
        public virtual DbSet<UserImage> UserImages { get; set; }
        public virtual DbSet<ProjectStatu> ProjectStatus { get; set; }
        public virtual DbSet<ViewProjectStatu> ViewProjectStatus { get; set; }
        public virtual DbSet<ViewProject> ViewProjects { get; set; }
        public virtual DbSet<ViewExpenseItemStatusActivity> ViewExpenseItemStatusActivities { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual DbSet<PaymentGiven> PaymentGivens { get; set; }
        public virtual DbSet<PaymentReceived> PaymentReceiveds { get; set; }
        public virtual DbSet<ViewPaymentReceived> ViewPaymentReceiveds { get; set; }
        public virtual DbSet<ViewPaymentGiven> ViewPaymentGivens { get; set; }
        public virtual DbSet<SellInvoice> SellInvoices { get; set; }
        public virtual DbSet<ViewPurchaseInvoice> ViewPurchaseInvoices { get; set; }
        public virtual DbSet<NewViewPaymentGiven> NewViewPaymentGivens { get; set; }
        public virtual DbSet<NewViewPaymentReceived> NewViewPaymentReceiveds { get; set; }
        public virtual DbSet<NewViewPurchaseInvoice> NewViewPurchaseInvoices { get; set; }
        public virtual DbSet<ViewSellInvoice> ViewSellInvoices { get; set; }
        public virtual DbSet<NewViewSellInvoice> NewViewSellInvoices { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<ViewTransaction> ViewTransactions { get; set; }
        public virtual DbSet<NewViewActivity> NewViewActivities { get; set; }
        public virtual DbSet<ExpenseItem> ExpenseItems { get; set; }
        public virtual DbSet<GST> GSTs { get; set; }
        public virtual DbSet<TD> TDS { get; set; }
        public virtual DbSet<ViewGST> ViewGSTs { get; set; }
        public virtual DbSet<ViewTD> ViewTDS { get; set; }
        public virtual DbSet<ViewDailyExpenseItemEmployee> ViewDailyExpenseItemEmployees { get; set; }
        public virtual DbSet<ViewDailyExpenseItemOrganization> ViewDailyExpenseItemOrganizations { get; set; }
        public virtual DbSet<ViewDailyExpenseItemProject> ViewDailyExpenseItemProjects { get; set; }
        public virtual DbSet<ViewExpenseItemDailyStatu> ViewExpenseItemDailyStatus { get; set; }
    }
}