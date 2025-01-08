namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietNhapHang")]
    public partial class ChiTietNhapHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaNH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        public virtual NhapHang NhapHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
