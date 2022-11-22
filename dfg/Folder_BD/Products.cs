namespace dfg.Folder_BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Basket = new HashSet<Basket>();
            Order_composition = new HashSet<Order_composition>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string article_number { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        public int count_of_stok { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        public string image { get; set; }

        public decimal price { get; set; }

        public double discount { get; set; }

        public int id_ed_izmerenia { get; set; }

        public int id_category { get; set; }

        public int id_supplier { get; set; }

        public int id_manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basket> Basket { get; set; }

        public virtual Category Category { get; set; }

        public virtual Ed_izmerenia Ed_izmerenia { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_composition> Order_composition { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
