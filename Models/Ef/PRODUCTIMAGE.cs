namespace Models.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCTIMAGE")]
    public partial class PRODUCTIMAGE
    {
        [Key]
        public int ImageID { get; set; }

        [StringLength(4000)]
        public string DetailImage_1 { get; set; }

        [StringLength(4000)]
        public string DetailImage_2 { get; set; }

        [StringLength(4000)]
        public string DetailImage_3 { get; set; }

        [StringLength(20)]
        public string ProductID { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
