namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheThanhVien")]
    public partial class TheThanhVien
    {
        [Key]
        [StringLength(10)]
        public string MaThe { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCap { get; set; }

        public int? TichLuy { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
