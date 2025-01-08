namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapHang")]
    public partial class NhapHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhapHang()
        {
            ChiTietNhapHangs = new HashSet<ChiTietNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaNH { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        public long? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietNhapHang> ChiTietNhapHangs { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
