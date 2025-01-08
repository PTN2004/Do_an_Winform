namespace Do_An.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            NhapHangs = new HashSet<NhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaNCC { get; set; }

        [StringLength(100)]
        public string TenNCC { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapHang> NhapHangs { get; set; }
    }
}
