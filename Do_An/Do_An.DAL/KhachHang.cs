namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
            TheThanhViens = new HashSet<TheThanhVien>();
        }

        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheThanhVien> TheThanhViens { get; set; }
    }
}
