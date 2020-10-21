namespace QL_NHANSU.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<DuAn> DuAns { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<ThanNhan> ThanNhans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DuAn>()
                .HasMany(e => e.PhanCongs)
                .WithRequired(e => e.DuAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.NhanVien1)
                .WithOptional(e => e.NhanVien2)
                .HasForeignKey(e => e.NgGS);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhanCongs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhongBans)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaTP);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ThanNhans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.PhongBan)
                .HasForeignKey(e => e.MaPB);
        }
    }
}
