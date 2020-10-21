namespace QL_NHANSU.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongBan")]
    public partial class PhongBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongBan()
        {
            DuAns = new HashSet<DuAn>();
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public int MaPB { get; set; }

        [StringLength(50)]
        public string TenPB { get; set; }

        public int? MaTP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ng_NC { get; set; }

        public int? SoNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DuAn> DuAns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
