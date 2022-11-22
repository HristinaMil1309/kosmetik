namespace dfg.Folder_BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Basket")]
    public partial class Basket
    {
        public int id { get; set; }

        public int id_order { get; set; }

        public int id_products { get; set; }

        public int id_users { get; set; }

        public int count_products { get; set; }

        public virtual Order Order { get; set; }

        public virtual Products Products { get; set; }

        public virtual Users Users { get; set; }
    }
}
