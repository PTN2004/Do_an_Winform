namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public long? TongTien { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaKM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
