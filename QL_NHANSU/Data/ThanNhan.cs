namespace QL_NHANSU.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanNhan")]
    public partial class ThanNhan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenTN { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string QuanHe { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
