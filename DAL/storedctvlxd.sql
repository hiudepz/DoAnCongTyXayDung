use CongTyXayDung;
go
create proc sp_XuatNhaThau
as
begin
    select * from NhaThau;
end;
exec sp_XuatNhaThau
go
create proc sp_XuatCongTrinh
as
begin
    select * from CongTrinh;
end;

exec sp_XuatCongTrinh
go
-----------------------------
CREATE OR ALTER PROC sp_BaoCaoTongChiPhi
    @tenCongTrinh NVARCHAR(100) = NULL
AS
BEGIN
    -- Tạo bảng tạm để lưu kết quả
    IF OBJECT_ID('tempdb..#KetQua') IS NOT NULL
        DROP TABLE #KetQua;

    SELECT 
        ct.ten AS TenCongTrinh,
        ISNULL(vattu.TongChiPhiVatTu, 0) AS ChiPhiVatTu,
        ISNULL(nhancong.TongChiPhiNhanCong, 0) AS ChiPhiNhanCong,
        ISNULL(vattu.TongChiPhiVatTu, 0) + ISNULL(nhancong.TongChiPhiNhanCong, 0) AS TongChiPhi
    INTO #KetQua
    FROM CongTrinh ct
    LEFT JOIN (
        SELECT cong_trinh_id, SUM(so_luong * don_gia) AS TongChiPhiVatTu
        FROM CongTrinh_VatTu
        GROUP BY cong_trinh_id
    ) vattu ON vattu.cong_trinh_id = ct.id
    LEFT JOIN (
        SELECT pc.cong_trinh_id,
               SUM(DATEDIFF(DAY, pc.ngay_bat_dau, pc.ngay_ket_thuc) * nc.luong_ngay) AS TongChiPhiNhanCong
        FROM PhanCong pc
        JOIN NhanCong nc ON pc.nhan_cong_id = nc.id
        GROUP BY pc.cong_trinh_id
    ) nhancong ON nhancong.cong_trinh_id = ct.id
    WHERE @tenCongTrinh IS NULL OR ct.ten LIKE N'%' + @tenCongTrinh + '%';

    -- Nếu không có dữ liệu
    IF NOT EXISTS (SELECT 1 FROM #KetQua)
    BEGIN
        PRINT N'Không tìm thấy công trình nào phù hợp.';
    END
    ELSE
    BEGIN
        SELECT * FROM #KetQua;
    END
END
-- Hiện tất cả công trình
EXEC sp_BaoCaoTongChiPhi;

-- Tìm theo công trình cụ thể
EXEC sp_BaoCaoTongChiPhi N'Cầu Bình Lợi';

------------------------------
CREATE OR ALTER PROC sp_DanhSachVatTuVaTongChiPhi
    @tenCongTrinh NVARCHAR(100) = NULL
AS
BEGIN
    -- Chi tiết từng vật tư đã sử dụng
    SELECT 
        ct.ten AS TenCongTrinh,
        vt.ten AS TenVatTu,
        ctvt.so_luong,
        ctvt.don_gia,
        (ctvt.so_luong * ctvt.don_gia) AS ThanhTien,
        ctvt.ngay_su_dung
    FROM 
        dbo.CongTrinh_VatTu ctvt
    INNER JOIN CongTrinh ct ON ctvt.cong_trinh_id = ct.id
    INNER JOIN VatTu vt ON ctvt.vat_tu_id = vt.id
    WHERE @tenCongTrinh IS NULL OR ct.ten LIKE N'%' + @tenCongTrinh + '%'

    -- Tổng chi phí vật tư theo từng công trình
    SELECT 
        ct.ten AS TenCongTrinh,
        SUM(ctvt.so_luong * ctvt.don_gia) AS TongChiPhi
    FROM 
        dbo.CongTrinh_VatTu ctvt
    INNER JOIN CongTrinh ct ON ctvt.cong_trinh_id = ct.id
    WHERE @tenCongTrinh IS NULL OR ct.ten LIKE N'%' + @tenCongTrinh + '%'
    GROUP BY ct.ten
END;

exec sp_DanhSachVatTuVaTongChiPhi N'';

GO

CREATE OR ALTER PROC sp_TimNhaThauTheoCongTrinh
    @tenCongTrinh NVARCHAR(100)
AS
BEGIN
if @tenCongTrinh is null 
begin 
 SELECT 
        ct.ten AS TenCongTrinh,
        nt.ten_cong_ty AS TenNhaThau,
        nt.dia_chi,
        nt.so_dien_thoai,
        nt.email,
        ctn.vai_tro
    FROM 
        CongTrinh ct
    INNER JOIN CongTrinh_NhaThau ctn ON ct.id = ctn.cong_trinh_id
    INNER JOIN NhaThau nt ON ctn.nha_thau_id = nt.id
end
else
begin
    SELECT 
        ct.ten AS TenCongTrinh,
        nt.ten_cong_ty AS TenNhaThau,
        nt.dia_chi,
        nt.so_dien_thoai,
        nt.email,
        ctn.vai_tro
    FROM 
        CongTrinh ct
    INNER JOIN CongTrinh_NhaThau ctn ON ct.id = ctn.cong_trinh_id
    INNER JOIN NhaThau nt ON ctn.nha_thau_id = nt.id
    WHERE 
        ct.ten LIKE '%' + @tenCongTrinh + '%';
END
end;
EXEC sp_TimNhaThauTheoCongTrinh N'';
select * from CongTrinh_NhaThau
SELECT id, ten as ten_cong_trinh FROM CongTrinh;
SELECT id, ten_cong_ty FROM NhaThau;


--DanhSachNhanCong_TheoCongTrinh
CREATE PROCEDURE sp_DanhSachNhanCong_TheoCongTrinh
    @CongTrinhID INT
AS
BEGIN
    SELECT 
        nc.id AS MaNhanCong,
        nc.ho_ten AS HoTen,
        nc.chuc_vu AS ChucVu,
        nc.luong_ngay AS LuongNgay,
        pc.ngay_bat_dau AS NgayBatDau,
        pc.ngay_ket_thuc AS NgayKetThuc
    FROM PhanCong pc
    INNER JOIN NhanCong nc ON pc.nhan_cong_id = nc.id
    WHERE pc.cong_trinh_id = @CongTrinhID
END

EXEC sp_DanhSachNhanCong_TheoCongTrinh N'1';

--TienDo_TheoCongTrinh
CREATE PROCEDURE sp_TienDo_TheoCongTrinh
    @CongTrinhID INT
AS
BEGIN
    SELECT 
		ct.ten AS "Tên Công Trình",
        td.ngay_cap_nhat AS NgayCapNhat,
        td.phan_tram_hoan_thanh AS TienDo,
        td.mo_ta AS MoTa
    FROM TienDo td
	  INNER JOIN CongTrinh ct ON td.cong_trinh_id = ct.id
    WHERE td.cong_trinh_id = @CongTrinhID
    ORDER BY td.ngay_cap_nhat ASC
END

EXEC sp_TienDo_TheoCongTrinh N'2';

--ChiPhiTong_TheoCongTrinh
CREATE PROCEDURE sp_ChiPhiTong_TheoCongTrinh
    @CongTrinhID INT
AS
BEGIN
    -- Tổng chi phí vật tư
    DECLARE @ChiPhiVatTu DECIMAL(18,2) = (
        SELECT SUM(so_luong * don_gia)
        FROM CongTrinh_VatTu
        WHERE cong_trinh_id = @CongTrinhID
    );

    -- Tổng chi phí nhân công
    DECLARE @ChiPhiNhanCong DECIMAL(18,2) = (
        SELECT SUM(DATEDIFF(DAY, pc.ngay_bat_dau, pc.ngay_ket_thuc) * nc.luong_ngay)
        FROM PhanCong pc
        INNER JOIN NhanCong nc ON pc.nhan_cong_id = nc.id
        WHERE pc.cong_trinh_id = @CongTrinhID
    );

    -- Trả kết quả tổng hợp
    SELECT 
		ct.ten AS "Tên Công Trình",
        @ChiPhiVatTu AS "Tổng Chi Phí Vật Tư",
        @ChiPhiNhanCong AS "Tổng Chi Phí Nhân Công",
        (@ChiPhiVatTu + @ChiPhiNhanCong) AS "Tổng Chi Phí"
		FROM CongTrinh ct
		WHERE ct.id = @CongTrinhID
END

EXEC sp_ChiPhiTong_TheoCongTrinh N'1';