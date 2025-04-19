USE CongTyXayDung;
GO

-- 1. Dữ liệu mẫu cho bảng Công trình
INSERT INTO CongTrinh (ten, dia_diem, chu_dau_tu, ngay_bat_dau, ngay_du_kien_ket_thuc, trang_thai, tong_muc_dau_tu, hinh_anh)
VALUES 
(N'Nhà máy A', N'Hà Nội', N'Công ty X', '2025-01-01', '2025-12-31', N'Đang thi công', 1500000000, N'image1.jpg'),
(N'Cầu B', N'Hồ Chí Minh', N'Công ty Y', '2024-05-10', '2026-05-10', N'Chưa bắt đầu', 3200000000, N'image2.jpg'),
(N'Đường cao tốc C', N'Đà Nẵng', N'Công ty Z', '2023-09-15', '2025-09-15', N'Tạm dừng', 4800000000, N'image3.jpg');
GO

-- 2. Dữ liệu mẫu cho bảng Nhà thầu
INSERT INTO NhaThau (ten_cong_ty, ma_so_thue, dia_chi, nguoi_dai_dien, so_dien_thoai, email)
VALUES 
(N'Công ty Xây dựng 123', '123456789', N'Hà Nội', N'Tran Van A', '0987654321', 'xaydung123@gmail.com'),
(N'Công ty Cầu đường ABC', '987654321', N'Hồ Chí Minh', N'Nguyen Thi B', '0978654321', 'cauduongabc@gmail.com');
GO

-- 3. Dữ liệu mẫu cho bảng Vật tư
INSERT INTO VatTu (ma_vat_tu, ten, don_vi_tinh, don_gia, nha_cung_cap, hinh_anh)
VALUES 
('VT001', N'Xi măng', N'Bao', 75000, N'Công ty VLXD A', N'vattu1.jpg'),
('VT002', N'Thép', N'Tấn', 12000000, N'Công ty VLXD B', N'vattu2.jpg'),
('VT003', N'Gạch', N'Viên', 5000, N'Công ty VLXD C', N'vattu3.jpg');
GO

-- 4. Dữ liệu mẫu cho bảng Công trình - Nhà thầu
INSERT INTO CongTrinh_NhaThau (cong_trinh_id, nha_thau_id, vai_tro)
VALUES 
(1, 1, N'Thi công móng'),
(2, 2, N'Xây dựng cầu');
GO

-- 5. Dữ liệu mẫu cho bảng Công trình - Vật tư
INSERT INTO CongTrinh_VatTu (cong_trinh_id, vat_tu_id, so_luong, don_gia, ngay_su_dung)
VALUES 
(1, 1, 1000, 75000, '2025-02-01'),
(1, 2, 50, 12000000, '2025-02-15'),
(2, 3, 10000, 5000, '2025-06-01');
GO

-- 6. Dữ liệu mẫu cho bảng Nhân công
INSERT INTO NhanCong (ho_ten, chuc_vu, luong_ngay, so_dien_thoai)
VALUES 
(N'Tran Van D', N'Kỹ sư', 500000, '0901123456'),
(N'Nguyen Thi E', N'Công nhân', 350000, '0901234567');
GO

-- 7. Dữ liệu mẫu cho bảng Phân công
INSERT INTO PhanCong (cong_trinh_id, nhan_cong_id, ngay_bat_dau, ngay_ket_thuc)
VALUES 
(1, 1, '2025-01-15', '2025-03-30'),
(1, 2, '2025-01-20', '2025-04-15');
GO

-- 8. Dữ liệu mẫu cho bảng Tiến độ
INSERT INTO TienDo (cong_trinh_id, ngay_cap_nhat, mo_ta, phan_tram_hoan_thanh)
VALUES 
(1, '2025-03-01', N'Thi công xong phần móng', 30),
(2, '2025-06-15', N'Đã hoàn thành thiết kế', 10);
GO

-- 9. Dữ liệu mẫu cho bảng Người dùng (Admin & User)
INSERT INTO NguoiDung (ten_dang_nhap, mat_khau, ho_ten, so_dien_thoai, email, vai_tro)
VALUES 
('admin', '123456', N'Admin', '0987654321', 'admin@example.com', N'Admin'),
('user1', 'abcdef', N'Nguyen Van A', '0978654321', 'user1@example.com', N'User'),
('user2', 'ghijkl', N'Tran Thi B', '0967543210', 'user2@example.com', N'User');
GO

select * from NguoiDung