using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnWinform.Models
{
    public partial class DBContextModel : DbContext
    {
        public DBContextModel()
            : base("name=DBContextModel")
        {
        }

        public virtual DbSet<GioiTinh> GioiTinh { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LichSuKhachHang> LichSuKhachHang { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhong { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoan { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<ThanhToan> ThanhToan { get; set; }
        public virtual DbSet<ThongTinPhong> ThongTinPhong { get; set; }
        public virtual DbSet<TrangThai> TrangThai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GioiTinh>()
                .HasMany(e => e.KhachHang)
                .WithRequired(e => e.GioiTinh1)
                .HasForeignKey(e => e.GioiTinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GioiTinh>()
                .HasMany(e => e.LichSuKhachHang)
                .WithRequired(e => e.GioiTinh1)
                .HasForeignKey(e => e.GioiTinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GioiTinh>()
                .HasMany(e => e.Login)
                .WithRequired(e => e.GioiTinh)
                .HasForeignKey(e => e.GioiTinhNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GioiTinh>()
                .HasMany(e => e.ThanhToan)
                .WithRequired(e => e.GioiTinh1)
                .HasForeignKey(e => e.GioiTinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.ThongTinPhong)
                .WithRequired(e => e.LoaiPhong1)
                .HasForeignKey(e => e.LoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiTaiKhoan>()
                .HasMany(e => e.Login)
                .WithRequired(e => e.LoaiTaiKhoan1)
                .HasForeignKey(e => e.LoaiTaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrangThai>()
                .HasMany(e => e.ThongTinPhong)
                .WithRequired(e => e.TrangThai1)
                .HasForeignKey(e => e.TrangThai)
                .WillCascadeOnDelete(false);
        }
    }
}
