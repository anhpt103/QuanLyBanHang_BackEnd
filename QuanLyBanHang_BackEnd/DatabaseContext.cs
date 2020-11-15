using Microsoft.EntityFrameworkCore;
using QuanLyBanHang_BackEnd.Models;

namespace QuanLyBanHang_BackEnd
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HangHoa>(entity =>
            {
                entity.HasKey(e => e.IdHangHoa);
                entity.Property(e => e.TenHangHoa).IsRequired();
                entity.Property(e => e.MaDonVi).IsRequired();
            });

            modelBuilder.Entity<HangHoa_GiaBan>(entity =>
            {
                entity.HasKey(e => e.IdHangHoa_GiaBan);
                entity.Property(e => e.IdHangHoa).IsRequired();
                entity.Property(e => e.MaDonViCon).IsRequired();
                entity.Property(e => e.MaDonVi).IsRequired();
                entity.HasOne(d => d.HangHoa)
                  .WithMany(p => p.HangHoa_GiaBans);
            });
        }

        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<HangHoa_GiaBan> HangHoa_GiaBans { get; set; }
    }
}
