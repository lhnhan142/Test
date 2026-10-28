using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLSanPham.Models;

public partial class QL_sanPhamContext : DbContext
{
    public QL_sanPhamContext()
    {
    }

    public QL_sanPhamContext(DbContextOptions<QL_sanPhamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Nhan;Database=QLSanPham;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__LoaiSP__730A5759794C4FBA");

            entity.ToTable("LoaiSP");

            entity.Property(e => e.MaLoai)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C865CDC80");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.TenSp)
                .HasMaxLength(100)
                .HasColumnName("TenSP");
            entity.Property(e => e.TrangThai).HasMaxLength(20);

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MaLoai__4F7CD00D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
