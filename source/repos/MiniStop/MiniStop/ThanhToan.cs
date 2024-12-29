namespace MiniStop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        [Key]
        public int MaThanhToan { get; set; }

        public int? MaDonHang { get; set; }

        public decimal? SoTienThanhToan { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        public virtual DonHang DonHang { get; set; }
    }
}
