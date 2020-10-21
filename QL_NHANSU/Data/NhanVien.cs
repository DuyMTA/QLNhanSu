namespace QL_NHANSU.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            NhanVien1 = new HashSet<NhanVien>();
            PhanCongs = new HashSet<PhanCong>();
            PhongBans = new HashSet<PhongBan>();
            ThanNhans = new HashSet<ThanNhan>();
        }

        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DChi { get; set; }

        [StringLength(10)]
        public string GTinh { get; set; }

        public int? Luong { get; set; }

        public int? MaPB { get; set; }

        public int? NgGS { get; set; }

        public int? SoNVDuoiQuyen { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanVien1 { get; set; }

        public virtual NhanVien NhanVien2 { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongBan> PhongBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanNhan> ThanNhans { get; set; }
    }
}
