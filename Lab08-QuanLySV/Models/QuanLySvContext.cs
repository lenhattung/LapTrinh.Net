using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab08_QuanLySV.Models;

public partial class QuanLySvContext : DbContext
{
    public QuanLySvContext()
    {
    }

    public QuanLySvContext(DbContextOptions<QuanLySvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KetQua> KetQuas { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Mon> Mons { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=QuanLySV;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KetQua>(entity =>
        {
            entity.HasKey(e => new { e.MaSo, e.MaMh }).HasName("PK__KetQua__A5575580A3720840");

            entity.ToTable("KetQua");

            entity.Property(e => e.MaMh)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("MaMH");

            entity.HasOne(d => d.MaMhNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaMh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQua__MaMH__403A8C7D");

            entity.HasOne(d => d.MaSoNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaSo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KetQua__MaSo__3F466844");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__KHOA__6539040506065EFA");

            entity.ToTable("KHOA");

            entity.Property(e => e.MaKhoa)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.TenKhoa)
                .HasMaxLength(30)
                .IsFixedLength();
        });

        modelBuilder.Entity<Mon>(entity =>
        {
            entity.HasKey(e => e.MaMh).HasName("PK__Mon__2725DFD9B8C9D3C2");

            entity.ToTable("Mon");

            entity.Property(e => e.MaMh)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("MaMH");
            entity.Property(e => e.TenMh)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("TenMH");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSo).HasName("PK__SinhVien__2725087D665841E7");

            entity.ToTable("SinhVien");

            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.GioiTinh).HasDefaultValue(true);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MaKhoa)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhoaNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaKhoa)
                .HasConstraintName("FK__SinhVien__MaKhoa__3A81B327");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
