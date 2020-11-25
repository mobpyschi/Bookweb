//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_BookStoreCT.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.DetailBills = new HashSet<DetailBill>();
        }
    
        public int Bill_ID { get; set; }
        public Nullable<System.DateTime> date_set { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string phoneNumber { get; set; }
        public Nullable<bool> isPayment { get; set; }
        public Nullable<bool> isDelivered { get; set; }
        public Nullable<System.DateTime> delivery_date { get; set; }
        public Nullable<int> total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailBill> DetailBills { get; set; }
    }
}