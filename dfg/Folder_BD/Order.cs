namespace dfg.Folder_BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Basket = new HashSet<Basket>();
            Order_composition1 = new HashSet<Order_composition>();
        }

        public int id { get; set; }

        public int number_order { get; set; }

        [Required]
        [StringLength(50)]
        public string order_composition { get; set; }

        public int? id_user { get; set; }

        public DateTime order_date { get; set; }

        public DateTime delivery_date { get; set; }

        public int code { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public int punkt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_composition> Order_composition1 { get; set; }

        public virtual Users Users { get; set; }
    }
}
