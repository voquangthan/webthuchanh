using Microsoft.EntityFrameworkCore;
using QuanLyNhanVienAPI.Model;

namespace QuanLyNhanVienAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Nhanvien> NHANVIEN { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //cho maxnv làm khóa chính
        {
            modelBuilder.Entity<Nhanvien>().HasKey(nv => nv.Manv);
        }

    }
}