-- Tạo database
CREATE DATABASE CongTyXayDung;
GO

USE CongTyXayDung;
GO

-- 1. Bảng Công trình
CREATE TABLE CongTrinh (
    id INT PRIMARY KEY IDENTITY(1,1),
    ten NVARCHAR(100) NOT NULL,
    dia_diem NVARCHAR(200) NOT NULL,
    chu_dau_tu NVARCHAR(100),
    ngay_bat_dau DATE,
    ngay_du_kien_ket_thuc DATE,
    ngay_hoan_thanh DATE,
    trang_thai NVARCHAR(20) DEFAULT N'Chưa bắt đầu',
    tong_muc_dau_tu DECIMAL(15,2),
    hinh_anh NVARCHAR(255),
    CONSTRAINT CK_CongTrinh_TrangThai CHECK (trang_thai IN (N'Chưa bắt đầu', N'Đang thi công', N'Tạm dừng', N'Đã hoàn thành'))
);
GO

-- 2. Bảng Nhà thầu
CREATE TABLE NhaThau (
    id INT PRIMARY KEY IDENTITY(1,1),
    ten_cong_ty NVARCHAR(100) NOT NULL,
    ma_so_thue VARCHAR(20),
    dia_chi NVARCHAR(200),
    nguoi_dai_dien NVARCHAR(50),
    so_dien_thoai VARCHAR(15),
    email VARCHAR(50)
);
GO

-- 3. Bảng Vật tư
CREATE TABLE VatTu (
    id INT PRIMARY KEY IDENTITY(1,1),
    ma_vat_tu VARCHAR(20) UNIQUE,
    ten NVARCHAR(100) NOT NULL,
    don_vi_tinh NVARCHAR(20),
    don_gia DECIMAL(12,2),
    nha_cung_cap NVARCHAR(100),
    hinh_anh NVARCHAR(255)
);
GO

-- 4. Bảng liên kết Công trình - Nhà thầu
CREATE TABLE CongTrinh_NhaThau (
    cong_trinh_id INT,
    nha_thau_id INT,
    vai_tro NVARCHAR(50),
    PRIMARY KEY (cong_trinh_id, nha_thau_id),
    FOREIGN KEY (cong_trinh_id) REFERENCES CongTrinh(id),
    FOREIGN KEY (nha_thau_id) REFERENCES NhaThau(id)
);
GO

-- 5. Bảng chi tiết Vật tư sử dụng trong Công trình
CREATE TABLE CongTrinh_VatTu (
    cong_trinh_id INT,
    vat_tu_id INT,
    so_luong DECIMAL(10,2),
    don_gia DECIMAL(12,2),
    ngay_su_dung DATE,
    PRIMARY KEY (cong_trinh_id, vat_tu_id, ngay_su_dung),
    FOREIGN KEY (cong_trinh_id) REFERENCES CongTrinh(id),
    FOREIGN KEY (vat_tu_id) REFERENCES VatTu(id)
);
GO

-- 6. Bảng Nhân công
CREATE TABLE NhanCong (
    id INT PRIMARY KEY IDENTITY(1,1),
    ho_ten NVARCHAR(50) NOT NULL,
    chuc_vu NVARCHAR(50),
    luong_ngay DECIMAL(10,2),
    so_dien_thoai VARCHAR(15)
);
GO

-- 7. Bảng Phân công nhân công
CREATE TABLE PhanCong (
    cong_trinh_id INT,
    nhan_cong_id INT,
    ngay_bat_dau DATE,
    ngay_ket_thuc DATE,
    PRIMARY KEY (cong_trinh_id, nhan_cong_id, ngay_bat_dau),
    FOREIGN KEY (cong_trinh_id) REFERENCES CongTrinh(id),
    FOREIGN KEY (nhan_cong_id) REFERENCES NhanCong(id)
);
GO

-- 8. Bảng Tiến độ công trình
CREATE TABLE TienDo (
    id INT PRIMARY KEY IDENTITY(1,1),
    cong_trinh_id INT,
    ngay_cap_nhat DATE,
    mo_ta NVARCHAR(MAX),
    phan_tram_hoan_thanh DECIMAL(5,2),
    FOREIGN KEY (cong_trinh_id) REFERENCES CongTrinh(id)
);
GO

-- 9. Bảng Người dùng (Admin & User)
CREATE TABLE NguoiDung (
    id INT PRIMARY KEY IDENTITY(1,1),
    ten_dang_nhap VARCHAR(50) NOT NULL UNIQUE,
    mat_khau VARCHAR(255) NOT NULL,
    ho_ten NVARCHAR(100),
    so_dien_thoai VARCHAR(15),
    email VARCHAR(100),
    vai_tro NVARCHAR(10) DEFAULT N'User',
    CONSTRAINT CK_VaiTro CHECK (vai_tro IN (N'Admin', N'User'))
);
GO
