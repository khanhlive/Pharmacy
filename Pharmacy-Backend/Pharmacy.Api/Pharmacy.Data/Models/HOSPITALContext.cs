using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pharmacy.Data.Models
{
    public partial class HOSPITALContext : DbContext
    {
        public HOSPITALContext()
        {
        }

        public HOSPITALContext(DbContextOptions<HOSPITALContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DicBenhvien> DicBenhvien { get; set; }
        public virtual DbSet<DicCanbo> DicCanbo { get; set; }
        public virtual DbSet<DicChucvu> DicChucvu { get; set; }
        public virtual DbSet<DicChuyenkhoa> DicChuyenkhoa { get; set; }
        public virtual DbSet<DicDantoc> DicDantoc { get; set; }
        public virtual DbSet<DicDichvu> DicDichvu { get; set; }
        public virtual DbSet<DicDoituong> DicDoituong { get; set; }
        public virtual DbSet<DicDtbn> DicDtbn { get; set; }
        public virtual DbSet<DicDuongdung> DicDuongdung { get; set; }
        public virtual DbSet<DicGioitinh> DicGioitinh { get; set; }
        public virtual DbSet<DicHuyen> DicHuyen { get; set; }
        public virtual DbSet<DicIcd10> DicIcd10 { get; set; }
        public virtual DbSet<DicNghenghiep> DicNghenghiep { get; set; }
        public virtual DbSet<DicNhacungcap> DicNhacungcap { get; set; }
        public virtual DbSet<DicNhomdichvu> DicNhomdichvu { get; set; }
        public virtual DbSet<DicPhanloaiphongban> DicPhanloaiphongban { get; set; }
        public virtual DbSet<DicPhongban> DicPhongban { get; set; }
        public virtual DbSet<DicTieunhomdichvu> DicTieunhomdichvu { get; set; }
        public virtual DbSet<DicTinh> DicTinh { get; set; }
        public virtual DbSet<DicXaphuong> DicXaphuong { get; set; }
        public virtual DbSet<SysGroupsystem> SysGroupsystem { get; set; }
        public virtual DbSet<SysRole> SysRole { get; set; }
        public virtual DbSet<SysRolePermissionMaping> SysRolePermissionMaping { get; set; }
        public virtual DbSet<SysSubsystem> SysSubsystem { get; set; }
        public virtual DbSet<SysUser> SysUser { get; set; }
        public virtual DbSet<VssBenhnhan> VssBenhnhan { get; set; }
        public virtual DbSet<VssBenhnhankhambenh> VssBenhnhankhambenh { get; set; }
        public virtual DbSet<VssCanlamsang> VssCanlamsang { get; set; }
        public virtual DbSet<VssCanlamsangChitiet> VssCanlamsangChitiet { get; set; }
        public virtual DbSet<VssChidinh> VssChidinh { get; set; }
        public virtual DbSet<VssDichvuchitiet> VssDichvuchitiet { get; set; }
        public virtual DbSet<VssDonthuoc> VssDonthuoc { get; set; }
        public virtual DbSet<VssDonthuochitiet> VssDonthuochitiet { get; set; }
        public virtual DbSet<VssNhapduocchitiet> VssNhapduocchitiet { get; set; }
        public virtual DbSet<VssNhapuoc> VssNhapuoc { get; set; }
        public virtual DbSet<VssPerson> VssPerson { get; set; }

        // Unable to generate entity type for table 'dbo.VSS_THONGTINBOSUNG'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=HOSPITAL;User ID=sa;Password=123456;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DicBenhvien>(entity =>
            {
                entity.HasKey(e => e.MaBenhVien);

                entity.ToTable("DIC_BENHVIEN");

                entity.Property(e => e.MaBenhVien)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Connect)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MaChuQuan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaHuyen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaTinh)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenBenhVien)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TuyenBenhVien)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHuyenNavigation)
                    .WithMany(p => p.DicBenhvien)
                    .HasForeignKey(d => d.MaHuyen)
                    .HasConstraintName("FK_DIC_BENHVIEN_DIC_HUYEN");

                entity.HasOne(d => d.MaTinhNavigation)
                    .WithMany(p => p.DicBenhvien)
                    .HasForeignKey(d => d.MaTinh)
                    .HasConstraintName("FK_DIC_BENHVIEN_DIC_TINH");
            });

            modelBuilder.Entity<DicCanbo>(entity =>
            {
                entity.HasKey(e => e.MaCanBo);

                entity.ToTable("DIC_CANBO");

                entity.HasIndex(e => new { e.TenCanBo, e.NgaySinh, e.GioiTinh, e.ChucVu, e.CapBac, e.KhoaChungTu, e.BangCap, e.MaPhongBan, e.MaDanToc, e.Image, e.DiaChi, e.SoDienThoai, e.MaCanBo })
                    .HasName("NonClusteredIndex-20180501-061138");

                entity.Property(e => e.MaCanBo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BangCap).HasMaxLength(50);

                entity.Property(e => e.CapBac)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.Image).HasColumnType("varbinary(max)");

                entity.Property(e => e.MaDanToc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TenCanBo).HasMaxLength(50);

                entity.HasOne(d => d.MaDanTocNavigation)
                    .WithMany(p => p.DicCanbo)
                    .HasForeignKey(d => d.MaDanToc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIC_CANBO__MaDan__182C9B23");

                entity.HasOne(d => d.MaPhongBanNavigation)
                    .WithMany(p => p.DicCanbo)
                    .HasForeignKey(d => d.MaPhongBan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIC_CANBO__MaPho__173876EA");
            });

            modelBuilder.Entity<DicChucvu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu);

                entity.ToTable("DIC_CHUCVU");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MoTa).HasMaxLength(250);

                entity.Property(e => e.TenChucVu)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DicChuyenkhoa>(entity =>
            {
                entity.HasKey(e => e.MaChuyenKhoa);

                entity.ToTable("DIC_CHUYENKHOA");

                entity.Property(e => e.MaChuyenKhoa).ValueGeneratedNever();

                entity.Property(e => e.MaQuyetDinh)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TenChiTiet).HasMaxLength(250);

                entity.Property(e => e.TenChuyenKhoa)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DicDantoc>(entity =>
            {
                entity.HasKey(e => e.MaDanToc);

                entity.ToTable("DIC_DANTOC");

                entity.HasIndex(e => new { e.TenDanToc, e.MoTa, e.Status, e.MaDanToc })
                    .HasName("NonClusteredIndex-20180501-061245");

                entity.Property(e => e.MaDanToc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.TenDanToc).HasMaxLength(50);
            });

            modelBuilder.Entity<DicDichvu>(entity =>
            {
                entity.HasKey(e => e.MaDichVu);

                entity.ToTable("DIC_DICHVU");

                entity.Property(e => e.BaoHiemYte).HasColumnName("BaoHiemYTe");

                entity.Property(e => e.BoPhanDung).HasMaxLength(250);

                entity.Property(e => e.DangBaoChe).HasMaxLength(200);

                entity.Property(e => e.DanhSachDoiTuongBenhNhan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DanhSachDonGia)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaBhyt)
                    .HasColumnName("DonGiaBHYT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaGioiHanTt04).HasColumnName("DonGiaGioiHanTT04");

                entity.Property(e => e.DonViNhap).HasMaxLength(100);

                entity.Property(e => e.DonViTinh).HasMaxLength(100);

                entity.Property(e => e.DuongDung).HasMaxLength(50);

                entity.Property(e => e.GoiThau).HasMaxLength(250);

                entity.Property(e => e.HamLuong).HasMaxLength(500);

                entity.Property(e => e.Loai).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoaiThau).HasMaxLength(250);

                entity.Property(e => e.LoaiThuoc).HasMaxLength(50);

                entity.Property(e => e.MaAtc)
                    .HasColumnName("MaATC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaDichVuBackUp)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaDuongDung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaHoatChat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhaCungCap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhongBanSd)
                    .HasColumnName("MaPhongBanSD")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MaQuyetDinh).HasMaxLength(100);

                entity.Property(e => e.MaTam).HasMaxLength(20);

                entity.Property(e => e.NgayQuyetDinh).HasColumnType("datetime");

                entity.Property(e => e.NguonGoc)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NhaSanXuat).HasMaxLength(500);

                entity.Property(e => e.NhaThau).HasMaxLength(250);

                entity.Property(e => e.NhomThau).HasMaxLength(150);

                entity.Property(e => e.NuocSanXuat).HasMaxLength(500);

                entity.Property(e => e.PhuongPhap).HasMaxLength(50);

                entity.Property(e => e.QuyCachPhamChat).HasMaxLength(50);

                entity.Property(e => e.SoDangKy).HasMaxLength(300);

                entity.Property(e => e.SoQuyetDinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SoThuTuQuyetDinh).HasMaxLength(20);

                entity.Property(e => e.TenDichVu).HasMaxLength(350);

                entity.Property(e => e.TenRutGon).HasMaxLength(300);

                entity.Property(e => e.TieuChuan).HasMaxLength(100);

                entity.Property(e => e.TinhTrangNhap)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TuoiTho).HasMaxLength(50);

                entity.Property(e => e.TyLeSuDung).HasDefaultValueSql("((1)/(1))");

                entity.Property(e => e.Ycsd)
                    .HasColumnName("YCSD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNhaCungCapNavigation)
                    .WithMany(p => p.DicDichvu)
                    .HasForeignKey(d => d.MaNhaCungCap)
                    .HasConstraintName("FK_DIC_DICHVU_DIC_NHACUNGCAP");

                entity.HasOne(d => d.MaTieuNhomDichVuNavigation)
                    .WithMany(p => p.DicDichvu)
                    .HasForeignKey(d => d.MaTieuNhomDichVu)
                    .HasConstraintName("FK_DIC_DICHVU_DIC_TIEUNHOMDICHVU");
            });

            modelBuilder.Entity<DicDoituong>(entity =>
            {
                entity.HasKey(e => e.MaDoiTuong);

                entity.ToTable("DIC_DOITUONG");

                entity.Property(e => e.MaDoiTuong)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NhomDoiTuong).HasMaxLength(20);

                entity.Property(e => e.TenDoiTuong)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DicDtbn>(entity =>
            {
                entity.HasKey(e => e.Iddtbn);

                entity.ToTable("DIC_DTBN");

                entity.Property(e => e.Iddtbn).HasColumnName("IDDTBN");

                entity.Property(e => e.MoTa).HasMaxLength(250);

                entity.Property(e => e.TenDtbn)
                    .HasColumnName("TenDTBN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DicDuongdung>(entity =>
            {
                entity.ToTable("DIC_DUONGDUNG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaDuongDung)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenDuongDung).HasMaxLength(200);
            });

            modelBuilder.Entity<DicGioitinh>(entity =>
            {
                entity.ToTable("DIC_GIOITINH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<DicHuyen>(entity =>
            {
                entity.HasKey(e => e.MaHuyen);

                entity.ToTable("DIC_HUYEN");

                entity.Property(e => e.MaHuyen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cap).HasMaxLength(150);

                entity.Property(e => e.MaTinh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenHuyen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaTinhNavigation)
                    .WithMany(p => p.DicHuyen)
                    .HasForeignKey(d => d.MaTinh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIC_HUYEN_DIC_TINH");
            });

            modelBuilder.Entity<DicIcd10>(entity =>
            {
                entity.HasKey(e => e.MaIcd);

                entity.ToTable("DIC_ICD10");

                entity.Property(e => e.MaIcd)
                    .HasColumnName("MaICD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMbicd).HasColumnName("ID_MBICD");

                entity.Property(e => e.Idcb).HasColumnName("IDCB");

                entity.Property(e => e.MaChuongBenh)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaIcd10)
                    .HasColumnName("MaICD10")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenChuongBenh).HasMaxLength(250);

                entity.Property(e => e.TenIcd)
                    .IsRequired()
                    .HasColumnName("TenICD")
                    .HasMaxLength(250);

                entity.Property(e => e.TenIcdYhct)
                    .HasColumnName("TenICD_YHCT")
                    .HasMaxLength(250);

                entity.Property(e => e.TenWho)
                    .HasColumnName("TenWHO")
                    .HasMaxLength(500);

                entity.Property(e => e.TenWhoe)
                    .HasColumnName("TenWHOe")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<DicNghenghiep>(entity =>
            {
                entity.HasKey(e => e.MaNgheNghiep);

                entity.ToTable("DIC_NGHENGHIEP");

                entity.Property(e => e.MaNgheNghiep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MoTa).HasMaxLength(250);

                entity.Property(e => e.TenNgheNghiep)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DicNhacungcap>(entity =>
            {
                entity.HasKey(e => e.MaNhaCungCap);

                entity.ToTable("DIC_NHACUNGCAP");

                entity.Property(e => e.MaNhaCungCap)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NguoiDaiDien).HasMaxLength(50);

                entity.Property(e => e.TenNhaCungCap)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DicNhomdichvu>(entity =>
            {
                entity.HasKey(e => e.MaNhom);

                entity.ToTable("DIC_NHOMDICHVU");

                entity.Property(e => e.MaNhom).ValueGeneratedNever();

                entity.Property(e => e.Bhyt).HasColumnName("BHYT");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TenNhomChiTiet).HasMaxLength(250);
            });

            modelBuilder.Entity<DicPhanloaiphongban>(entity =>
            {
                entity.ToTable("DIC_PHANLOAIPHONGBAN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhanLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<DicPhongban>(entity =>
            {
                entity.HasKey(e => e.MaPhongBan);

                entity.ToTable("DIC_PHONGBAN");

                entity.HasIndex(e => new { e.TenPhongBan, e.NhomPhongBan, e.ChuyenKhoa, e.PhanLoaiId, e.QuanLy, e.PhuongPhapXuatDuoc, e.PhuongPhapHuHaoDongY, e.DiaChi, e.MaBenhVien, e.Status, e.BuongGiuong, e.MaQuyetDinh, e.MaPhongBanCu, e.MaChuyenKhoa, e.TuTruc, e.TrongBenhVien, e.MaPhongBan })
                    .HasName("NonClusteredIndex-20180501-061222");

                entity.Property(e => e.BuongGiuong).HasMaxLength(500);

                entity.Property(e => e.ChuyenKhoa).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.MaBenhVien)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhongBanCu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaQuyetDinh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhanLoaiId).HasColumnName("PhanLoai_ID");

                entity.Property(e => e.TenPhongBan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaBenhVienNavigation)
                    .WithMany(p => p.DicPhongban)
                    .HasForeignKey(d => d.MaBenhVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIC_PHONGBAN_DIC_BENHVIEN");

                entity.HasOne(d => d.MaChuyenKhoaNavigation)
                    .WithMany(p => p.DicPhongban)
                    .HasForeignKey(d => d.MaChuyenKhoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIC_PHONG__MaChu__145C0A3F");

                entity.HasOne(d => d.PhanLoai)
                    .WithMany(p => p.DicPhongban)
                    .HasForeignKey(d => d.PhanLoaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIC_PHONGBAN_DIC_PHANLOAIPHONGBAN");
            });

            modelBuilder.Entity<DicTieunhomdichvu>(entity =>
            {
                entity.HasKey(e => e.MaTieuNhom);

                entity.ToTable("DIC_TIEUNHOMDICHVU");

                entity.Property(e => e.MaTieuNhom).ValueGeneratedNever();

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenRutGon).HasMaxLength(50);

                entity.Property(e => e.TenTieuNhom)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MaNhomNavigation)
                    .WithMany(p => p.DicTieunhomdichvu)
                    .HasForeignKey(d => d.MaNhom)
                    .HasConstraintName("FK__TieuNhomD__MaNho__4D5F7D71");
            });

            modelBuilder.Entity<DicTinh>(entity =>
            {
                entity.HasKey(e => e.MaTinh);

                entity.ToTable("DIC_TINH");

                entity.Property(e => e.MaTinh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cap).HasMaxLength(250);

                entity.Property(e => e.TenTinh)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DicXaphuong>(entity =>
            {
                entity.HasKey(e => e.MaXa);

                entity.ToTable("DIC_XAPHUONG");

                entity.Property(e => e.MaXa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cap).HasMaxLength(150);

                entity.Property(e => e.MaHuyen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenXa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TinhMa)
                    .HasColumnName("Tinh_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHuyenNavigation)
                    .WithMany(p => p.DicXaphuong)
                    .HasForeignKey(d => d.MaHuyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIC_XAPHU__MaHuy__07C12930");
            });

            modelBuilder.Entity<SysGroupsystem>(entity =>
            {
                entity.HasKey(e => new { e.SystemId, e.SystemCode });

                entity.ToTable("SYS_GROUPSYSTEM");

                entity.Property(e => e.SystemId)
                    .HasColumnName("SystemID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SystemCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.SystemName).HasMaxLength(150);
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("SYS_ROLE");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.RoleCode).HasMaxLength(20);

                entity.Property(e => e.RoleName).HasMaxLength(128);
            });

            modelBuilder.Entity<SysRolePermissionMaping>(entity =>
            {
                entity.ToTable("SYS_ROLE_PERMISSION_MAPING");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SubSystemId).HasColumnName("SubSystem_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysRolePermissionMaping)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYS_ROLE_PERMISSION_MAPING_SYS_ROLE");

                entity.HasOne(d => d.SubSystem)
                    .WithMany(p => p.SysRolePermissionMaping)
                    .HasForeignKey(d => d.SubSystemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SYS_ROLE_PERMISSION_MAPING_SYS_SUBSYSTEM");
            });

            modelBuilder.Entity<SysSubsystem>(entity =>
            {
                entity.HasKey(e => e.SubSystemId);

                entity.ToTable("SYS_SUBSYSTEM");

                entity.Property(e => e.SubSystemId).HasColumnName("SubSystemID");

                entity.Property(e => e.ActionName).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Controller).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.GroupSystemId).HasColumnName("GroupSystem_ID");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image).HasMaxLength(250);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(255);

                entity.Property(e => e.SubSystemCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SubSystemName).HasMaxLength(150);

                entity.Property(e => e.Url).HasMaxLength(250);
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("SYS_USER");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.LastIpLogon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysUser)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYS_USER_SYS_ROLE");
            });

            modelBuilder.Entity<VssBenhnhan>(entity =>
            {
                entity.ToTable("VSS_BENHNHAN");

                entity.HasIndex(e => new { e.Id, e.TenBenhNhan, e.SoTheBhyt, e.Tuoi, e.GioiTinhMa, e.NgaySinh, e.ThangSinh, e.NamSinh, e.NgayThangNamSinh, e.DiaChi, e.DoiTuong, e.NgayNhap, e.MaCoSo, e.LaBenhNhanNoiTru, e.TrieuChung, e.PhongBanMa, e.TuyenBenhVien, e.ChanDoanNoiGioiThieu, e.CapCuu, e.NoiTinh, e.SoThuTu, e.TrangThaiBenhNhan, e.HanBaoHiemTu, e.HanBaoHiemDen, e.BenhVienMa, e.ChuyenKhoaMa, e.LaNgoaiGio, e.TuyenDuoi, e.SoKhamBenh, e.MucHuongBaoHiem, e.KhuVuc, e.NgayHanMuc, e.LuongCoSo, e.LaUuTien, e.DieuTriNgoaiTru, e.DoiTuongMa, e.PersonMa, e.NoThe, e.DoiTuongBenhNhanMa, e.MaLienKet, e.MaKhamChuaBenh, e.Export, e.CanBoMa, e.MaBenhNhan })
                    .HasName("Index_MaBenhNhan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenhVienMa)
                    .HasColumnName("BenhVien_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChanDoanNoiGioiThieu).HasMaxLength(250);

                entity.Property(e => e.ChuyenKhoaMa)
                    .HasColumnName("ChuyenKhoa_Ma")
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.DoiTuong).HasMaxLength(10);

                entity.Property(e => e.DoiTuongBenhNhanMa).HasColumnName("DoiTuongBenhNhan_Ma");

                entity.Property(e => e.DoiTuongMa)
                    .HasColumnName("DoiTuong_Ma")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinhMa)
                    .HasColumnName("GioiTinh_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HanBaoHiemDen).HasColumnType("date");

                entity.Property(e => e.HanBaoHiemTu).HasColumnType("date");

                entity.Property(e => e.KhuVuc)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LuongCoSo).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MaBenhNhan)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaCoSo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaKhamChuaBenh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaLienKet)
                    .HasColumnName("Ma_LienKet")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MucHuongBaoHiem).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.NamSinh)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHanMuc).HasColumnType("date");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NgayThangNamSinh).HasColumnType("datetime");

                entity.Property(e => e.PersonMa).HasColumnName("Person_Ma");

                entity.Property(e => e.PhongBanMa).HasColumnName("PhongBan_Ma");

                entity.Property(e => e.SoTheBhyt)
                    .HasColumnName("SoTheBHYT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenBenhNhan).HasMaxLength(250);

                entity.Property(e => e.ThangSinh)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TrieuChung).HasMaxLength(250);
            });

            modelBuilder.Entity<VssBenhnhankhambenh>(entity =>
            {
                entity.ToTable("VSS_BENHNHANKHAMBENH");

                entity.HasIndex(e => new { e.Id, e.ChanDoan, e.PhongBanMa, e.NgayKham, e.PhuongAn, e.PhongBanDieuTriMa, e.BenhKhac, e.BuongDieuTri, e.GiuongDieuTri, e.ChuyenKhoaMa, e.ChuyenKhoa, e.IcdMa, e.Icd2Ma, e.NgayHen, e.NgayNghi, e.CanBoMa, e.GhiChu, e.BenhNhanMa })
                    .HasName("Index_MaBenhNhan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenhKhac).HasMaxLength(100);

                entity.Property(e => e.BenhNhanMa).HasColumnName("BenhNhan_Ma");

                entity.Property(e => e.BuongDieuTri).HasMaxLength(15);

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChanDoan).HasMaxLength(250);

                entity.Property(e => e.ChuyenKhoa).HasMaxLength(50);

                entity.Property(e => e.ChuyenKhoaMa).HasColumnName("ChuyenKhoa_Ma");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.GiuongDieuTri).HasMaxLength(10);

                entity.Property(e => e.Icd2Ma)
                    .HasColumnName("ICD2_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IcdMa)
                    .HasColumnName("ICD_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHen).HasColumnType("datetime");

                entity.Property(e => e.NgayKham).HasColumnType("datetime");

                entity.Property(e => e.NgayNghi).HasColumnType("datetime");

                entity.Property(e => e.PhongBanDieuTriMa).HasColumnName("PhongBanDieuTri_Ma");

                entity.Property(e => e.PhongBanMa).HasColumnName("PhongBan_Ma");
            });

            modelBuilder.Entity<VssCanlamsang>(entity =>
            {
                entity.ToTable("VSS_CANLAMSANG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BenhNhanMa).HasColumnName("BenhNhan_Ma");

                entity.Property(e => e.BenhPham).HasMaxLength(100);

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CanBoThucHienMa)
                    .HasColumnName("CanBoThucHien_Ma")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChanDoan).HasMaxLength(250);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DanhsachCanboThuchien).HasMaxLength(250);

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.IcdMa)
                    .HasColumnName("ICD_Ma")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idbb).HasColumnName("IDBB");

                entity.Property(e => e.NgayNhanKetQua).HasColumnType("datetime");

                entity.Property(e => e.NgayThang).HasColumnType("datetime");

                entity.Property(e => e.NgayThucHien).HasColumnType("datetime");

                entity.Property(e => e.PhongBanMa).HasColumnName("PhongBan_Ma");

                entity.Property(e => e.PhongBanThucHienMa).HasColumnName("PhongBanThucHien_Ma");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.ThoiGianLayMau).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianNhanMau).HasColumnType("datetime");

                entity.Property(e => e.TrangThaiBenhPham).HasMaxLength(50);
            });

            modelBuilder.Entity<VssCanlamsangChitiet>(entity =>
            {
                entity.ToTable("VSS_CANLAMSANG_CHITIET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CanLamSangId).HasColumnName("CanLamSang_ID");

                entity.Property(e => e.ChiDinh).HasMaxLength(250);

                entity.Property(e => e.ChiDinhId).HasColumnName("ChiDinh_ID");

                entity.Property(e => e.DichvuChitietMa)
                    .HasColumnName("DichvuChitiet_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DuongDan).HasMaxLength(250);

                entity.Property(e => e.DuongDan2).HasMaxLength(500);

                entity.Property(e => e.KetquaXetNghiem).HasMaxLength(50);

                entity.Property(e => e.Ngaythang).HasColumnType("datetime");

                entity.Property(e => e.Sttht).HasColumnName("STTHT");
            });

            modelBuilder.Entity<VssChidinh>(entity =>
            {
                entity.ToTable("VSS_CHIDINH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanBoThucHienMa)
                    .HasColumnName("CanBoThucHien_Ma")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CanLamSangId).HasColumnName("CanLamSang_ID");

                entity.Property(e => e.ChiDinh).HasMaxLength(250);

                entity.Property(e => e.DanhsachCanBoThuchien).HasMaxLength(250);

                entity.Property(e => e.DichVuMa).HasColumnName("DichVu_Ma");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.Icd9).HasColumnName("ICD9");

                entity.Property(e => e.MaMay).HasMaxLength(50);

                entity.Property(e => e.MauLanMtruongXn)
                    .HasColumnName("Mau_Lan_MTruongXN")
                    .HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(250);

                entity.Property(e => e.NgayThucHien).HasColumnType("datetime");

                entity.Property(e => e.NgoaiGioHanhChinh).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<VssDichvuchitiet>(entity =>
            {
                entity.ToTable("VSS_DICHVUCHITIET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DichVuMa).HasColumnName("DichVu_ma");

                entity.Property(e => e.DonVi).HasMaxLength(20);

                entity.Property(e => e.KetQua).HasMaxLength(250);

                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoThuTuF).HasColumnName("SoThuTu_F");

                entity.Property(e => e.SthuTuR).HasColumnName("SThuTu_R");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.Ten).HasMaxLength(250);

                entity.Property(e => e.TenMay).HasMaxLength(50);

                entity.Property(e => e.TriSoBinhThuong).HasMaxLength(250);

                entity.Property(e => e.TriSoBinhThuongNam)
                    .HasColumnName("TriSoBinhThuong_Nam")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TriSoBinhThuongNu)
                    .HasColumnName("TriSoBinhThuong_Nu")
                    .HasMaxLength(250);

                entity.Property(e => e.TriSoNamDen)
                    .HasColumnName("TriSoNam_Den")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TriSoNamTu)
                    .HasColumnName("TriSoNam_Tu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TriSoNuDen)
                    .HasColumnName("TriSoNu_Den")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TriSoNuTu)
                    .HasColumnName("TriSoNu_Tu")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VssDonthuoc>(entity =>
            {
                entity.ToTable("VSS_DONTHUOC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenhNhanMa).HasColumnName("BenhNhan_Ma");

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.NgayKeDon).HasColumnType("datetime");

                entity.Property(e => e.PhongBanMa).HasColumnName("PhongBan_Ma");

                entity.Property(e => e.PhongBanXuatMa).HasColumnName("PhongBanXuat_Ma");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<VssDonthuochitiet>(entity =>
            {
                entity.ToTable("VSS_DONTHUOCHITIET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenhNhanKhamBenhId).HasColumnName("BenhNhanKhamBenh_ID");

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChiDinhId).HasColumnName("ChiDinh_ID");

                entity.Property(e => e.DanhSachCanBoThucHien).HasMaxLength(250);

                entity.Property(e => e.DichVuMa).HasColumnName("DichVu_Ma");

                entity.Property(e => e.DonThuocChiTietAttachId).HasColumnName("DonThuocChiTietAttach_ID");

                entity.Property(e => e.DonThuocId).HasColumnName("DonThuoc_ID");

                entity.Property(e => e.DonVi).HasMaxLength(10);

                entity.Property(e => e.DonViUong).HasMaxLength(50);

                entity.Property(e => e.DuongDung).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.HanDung).HasColumnType("datetime");

                entity.Property(e => e.LieuLuong)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MoiLan).HasMaxLength(50);

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.NhaCungCapMa)
                    .HasColumnName("NhaCungCap_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhongBanMa).HasColumnName("PhongBan_Ma");

                entity.Property(e => e.PhongBanTongKetMa).HasColumnName("PhongBanTongKet_Ma");

                entity.Property(e => e.PhongBanXuatMa)
                    .HasColumnName("PhongBanXuat_Ma")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLan)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SoLo).HasMaxLength(20);

                entity.Property(e => e.TyLeThanhToan).HasDefaultValueSql("((100))");
            });

            modelBuilder.Entity<VssNhapduocchitiet>(entity =>
            {
                entity.ToTable("VSS_NHAPDUOCCHITIET");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenhNhanMa).HasColumnName("BenhNhan_Ma");

                entity.Property(e => e.DichVuMa).HasColumnName("DichVu_Ma");

                entity.Property(e => e.DoiTuongBenhNhanMa)
                    .HasColumnName("DoiTuongBenhNhan_Ma")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.DonVi).HasMaxLength(10);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.HanDung).HasColumnType("date");

                entity.Property(e => e.NhaCungCapMa)
                    .HasColumnName("NhaCUngCap_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NhapDuocId).HasColumnName("NhapDuoc_ID");

                entity.Property(e => e.SoDangKy).HasMaxLength(30);

                entity.Property(e => e.SoLo).HasMaxLength(20);

                entity.Property(e => e.TrongBaoHiem).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<VssNhapuoc>(entity =>
            {
                entity.ToTable("VSS_NHAPUOC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BenhNhanMa).HasColumnName("BenhNhan_Ma");

                entity.Property(e => e.CanBoMa)
                    .HasColumnName("CanBo_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.DoiTuongBenhNhanMa)
                    .HasColumnName("DoiTuongBenhNhan_Ma")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.Idsxthuoc).HasColumnName("IDSXThuoc");

                entity.Property(e => e.MaXp)
                    .HasColumnName("MaXP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.NgayNhapNvl)
                    .HasColumnName("NgayNhap_NVL")
                    .HasColumnType("datetime");

                entity.Property(e => e.NgayTt)
                    .HasColumnName("NgayTT")
                    .HasColumnType("datetime");

                entity.Property(e => e.NhaCungCapMa)
                    .HasColumnName("NhaCungCap_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhongBanMa).HasColumnName("PhongBan_Ma");

                entity.Property(e => e.PhongBanNhapXuatMa).HasColumnName("PhongBanNhapXuat_Ma");

                entity.Property(e => e.SoChungTu).HasMaxLength(50);

                entity.Property(e => e.SoPhieu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TangGiaSx)
                    .HasColumnName("TangGiaSX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TenNguoiCungCap).HasMaxLength(50);

                entity.Property(e => e.TraDuocKieuDon)
                    .HasColumnName("TraDuoc_KieuDon")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.XuatTd).HasColumnName("XuatTD");
            });

            modelBuilder.Entity<VssPerson>(entity =>
            {
                entity.ToTable("VSS_PERSON");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.DoiTuongMa)
                    .HasColumnName("DoiTuong_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinhMa)
                    .IsRequired()
                    .HasColumnName("GioiTinh_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HanBaoHiemDen).HasColumnType("date");

                entity.Property(e => e.HanBaoHiemTu).HasColumnType("date");

                entity.Property(e => e.HuyenMa)
                    .HasColumnName("Huyen_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KhuVuc)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCoSo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamSinh)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCap).HasColumnType("date");

                entity.Property(e => e.NgayHanMuc).HasColumnType("date");

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NgayThangNamSinh).HasColumnType("datetime");

                entity.Property(e => e.NoiSinh).HasMaxLength(250);

                entity.Property(e => e.SoTheBhyt)
                    .IsRequired()
                    .HasColumnName("SoTheBHYT")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TenBenhNhan)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThangSinh)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TinhMa)
                    .HasColumnName("Tinh_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.XaMa)
                    .HasColumnName("Xa_Ma")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
