using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DE03_2.Models
{
    public partial class QLNhanvienContext : DbContext
    {
        public QLNhanvienContext()
        {
        }

        public QLNhanvienContext(DbContextOptions<QLNhanvienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-DMM5NS68\\SQLEXPRESS;Initial Catalog=QLNhanvien;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E53985D80");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(4)
                    .HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(30);

                entity.Property(e => e.HoTen).HasMaxLength(25);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__Nhanvien__2725D70A3D0B7894");

                entity.ToTable("Nhanvien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.Hoten).HasMaxLength(30);

                entity.Property(e => e.MaPhong).HasMaxLength(2);

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.MaPhong)
                    .HasConstraintName("FK__Nhanvien__MaPhon__398D8EEE");
            });

            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.HasKey(e => e.MaPhong)
                    .HasName("PK__PhongBan__20BD5E5B7A76502E");

                entity.ToTable("PhongBan");

                entity.Property(e => e.MaPhong).HasMaxLength(2);

                entity.Property(e => e.TenPhong).HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
