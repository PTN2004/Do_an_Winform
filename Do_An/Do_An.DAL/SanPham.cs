namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietNhapHangs = new HashSet<ChiTietNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        public int Gia { get; set; }

        public int SoLuongTon { get; set; }

        public string DonViTinh { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

        [StringLength(100)]
        public string BarCode { get; set; }

        [StringLength(10)]
        public string MaLoaiSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietNhapHang> ChiTietNhapHangs { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
    }
}
