//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SalesInvoice
    {
        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        public int OrgId { get; set; }
        public int ProjectId { get; set; }
        public double ServiceCost { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public double IGST { get; set; }
        public double TDS { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public byte InvoiceType { get; set; }
    }
}
