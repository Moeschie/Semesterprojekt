//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetails()
        {
            this.Order = new HashSet<Order>();
        }
    
        public System.Guid Id { get; set; }
        public string Object { get; set; }
        public int OverallQuantity { get; set; }
        public string Foreign { get; set; }
        public string SplitForeinLand { get; set; }
        public string SplitHomeLand { get; set; }
        public string AdditionalInformation { get; set; }
        public string BillTo { get; set; }
        public string Material { get; set; }
        public string IncomeDate { get; set; }
        public string IncomeTime { get; set; }
        public string Deadline { get; set; }
        public string OrderEdition { get; set; }
        public string OrderName { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.Guid> Customer_Id { get; set; }
        public Nullable<System.Guid> Editor_Id { get; set; }
        public Nullable<System.Guid> RemainsToo_Id { get; set; }
        public string ProductionStart { get; set; }
        public string ProductionEnd { get; set; }
        public string ProductionTimespan { get; set; }
    
        public virtual Adress Adress { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        public virtual User User { get; set; }
    }
}
