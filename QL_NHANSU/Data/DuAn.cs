namespace QL_NHANSU.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DuAn")]
    public partial class DuAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DuAn()
        {
            PhanCongs = new HashSet<PhanCong>();
        }

        [Key]
        public int MaDA { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDA { get; set; }

        public int? MaPB { get; set; }

        [StringLength(50)]
        public string DiaDiem { get; set; }

        public int? tongsogio { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}
