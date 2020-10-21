namespace QL_NHANSU.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanCong")]
    public partial class PhanCong
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDA { get; set; }

        public int? SoGio { get; set; }

        public virtual DuAn DuAn { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
