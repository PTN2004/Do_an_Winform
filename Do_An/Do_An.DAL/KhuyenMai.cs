namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        [Key]
        [StringLength(10)]
        public string MaKM { get; set; }

        [StringLength(100)]
        public string TenKM { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public int? PhanTramGiam { get; set; }
    }
}
