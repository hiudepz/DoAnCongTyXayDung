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
