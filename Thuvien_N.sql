create database ThuVien_N
go
dr
use ThuVien_N
go
create table DocGia
(
	MaDocGia nchar(10),
	TenDangNhap nchar(30),
	HoTen nchar(30),
	GioiTinh nchar(5),
	NamSinh datetime,
	DiaChi nchar(100),
	PRIMARY KEY (MaDocGia)
)
create table Sach
(
	MaSach nchar(10),
	TenSach nchar(50),
	TacGia nchar(30),
	TheLoai nchar(30),
	NhaXuatBan nchar(50),
	GiaSach int,
	SoLuong int,
	TinhTrang nvarchar(10),
	PRIMARY KEY (MaSach)
)
create table PhieuMuon
(
	MaPhieuMuon nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayMuon datetime,
	NgayPhaiTra datetime,
	TinhTrang nvarchar(10),
	PRIMARY KEY (MaPhieuMuon)
)
create table PhieuTra
(
	MaPhieuTra nchar(10),
	MaPhieuMuon nchar(10),
	NgayTra datetime,
	TinhTrang nvarchar(10)
	PRIMARY KEY (MaPhieuTra),
)
create table TaiKHoan
(
	MaDocGia nchar(10) PRIMARY KEY,
	TenDangNhap nchar(30),
	MatKhau nchar(30),
	Quyen varchar(10)
)


alter table PHIEUTRA add
	constraint FK_PHIEUTRA_MUON foreign key (MaPhieuMuon) references PhieuMuon (MaPhieuMuon)

alter table PhieuMuon add
	constraint FK_PhieuMuon_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PhieuMuon_SACH foreign key (MaSach) references SACH (MaSach)

ALTER TABLE dbo.DOCGIA ADD
	CONSTRAINT FK_DOCGIA_TaiKHoan FOREIGN KEY (MaDocGia) REFERENCES dbo.TaiKHoan(MaDocGia)


insert into PHIEUMUON values ('PM0000','ID_001','MS0001','1/7/2020', '1/9/2020',N'Tốt')
insert into PHIEUMUON values ('PM0001','ID_001','MS0001','1/5/2018', '1/6/2018',N'Tốt')
insert into PHIEUMUON values ('PM0002','ID_002','MS0001','8/5/2018', '8/6/2018',N'Tốt')
insert into PHIEUMUON values ('PM0003','ID_003','MS0002','10/5/2018', '10/6/2018',N'Tốt')
insert into PHIEUMUON values ('PM0004','ID_004','MS0007', '3/9/2018', '3/10/2018',N'Tốt')
insert into PHIEUMUON values ('PM0005','ID_005','MS0006', '12/9/2018', '12/10/2018',N'Tốt')
insert into PHIEUMUON values ('PM0006','ID_006','MS0003', '5/9/2018', '5/10/2018',N'Tốt')
insert into PHIEUMUON values ('PM0007','ID_007','MS0008', '6/9/2018', '6/10/2018',N'Tốt')
insert into PHIEUMUON values ('PM0008','ID_008','MS0009', '2/10/2018', '2/11/2018',N'Tốt')
insert into PHIEUMUON values ('PM0009','ID_009','MS0005', '10/10/2018', '10/11/2018',N'Tốt')

insert into PHIEUTRA values ('PT0000','PM0008','5/5/2018',N'Tốt')
insert into PHIEUTRA values ('PT0001','PM0001','5/5/2018',N'Tốt')
insert into PHIEUTRA values ('PT0002','PM0002','10/5/2018',N'Tốt')
insert into PHIEUTRA values ('PT0003','PM0003','6/6/2018',N'Tốt')
insert into PHIEUTRA values ('PT0004','PM0004', '9/9/2018',N'Tốt')
insert into PHIEUTRA values ('PT0005','PM0005', '12/9/2018',N'Tốt')
insert into PHIEUTRA values ('PT0006','PM0006', '2/10/2018',N'Tốt')


insert into DOCGIA values ('ID_001','cuong',N'Nguyễn Thị Hà', N'Nữ', 1995,N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_002','trieuninhngan', N'Lê Thị Thảo',N'Nữ', 1996, N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_003','nguyenvinhhien', N'Nguyễn Thị Hồng Nhung', N'Nữ', 1996, N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_004','nguyenthihongnhung', N'Đinh Thị Phương', N'Nữ', 1997, N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_005','dinhthiphuong',N'Nguyễn Thị Bích Ngọc', N'Nữ',1997,N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_006','nguyenthibichngoc', N'Lê Thị Quỳnh', N'Nữ',1996, N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_007','lethiquynh', N'Lê Thị Phượng', N'Nữ', 1996, N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_008','nguyenminhtri', N'Nguyễn Minh Tú', N'Nữ',1997,N'236 Hoàng Quốc Việt')
insert into DOCGIA values ('ID_009','nguyenquockhanh', N'Đậu Thị Kim Dung', N'Nữ', 1996, N'236 Hoàng Quốc Việt')



insert into SACH values ('MS0001', N'Mạng máy tính', N'Lê Huy Trường', N'Mạng máy tính', 'HANU', 35000, 15, N'Còn')
insert into SACH values ('MS0002', N'Cấu trúc dữ liệu và giải thuật', N'Đỗ Xuân Lôi', N'Lập trình', 'HANU', 45000, 10, N'Còn')
insert into SACH values ('MS0003', N'Ngữ pháp Tiếng Anh', N'Đặng Đình Thiện', N'Ngoại ngữ', 'STU', 75000, 25, N'Còn')
insert into SACH values ('MS0004', N'Tiếng Anh chuyên ngành Công nghệ thông tin', N'Thạc Bình Cường', N'Ngoại ngữ', 'STU', 70000, 0, N'Hết')
insert into SACH values ('MS0005', N'Công nghệ phần mềm', N'Lê Đức Trung', N'Lập trình', 'HUST', 42000, 20, N'Còn')
insert into SACH values ('MS0006', N'Những người khốn khổ', N'Victor Hugo', N'Văn học', 'VH', 70000, 10, N'Còn')
insert into SACH values ('MS0007', N'Bố Già', N'Mario Puzo', N'Văn học', 'STU', 70000, 15, N'Còn')
insert into SACH values ('MS0008', N'Chiến tranh và hòa bình', N'Lev Tolstoy', N'Văn học', 'STU', 70000, 13, N'Còn')
insert into SACH values ('MS0009', N'Giết con chim nhại', N'Harper Lee', N'Văn học', 'STU', 170000, 0, N'Hết')
insert into SACH values ('MS0010', N'Tuổi thơ dữ dội', N'Phùng Quán', N'Văn học', 'STU', 100000, 20, N'Còn')
insert into SACH values ('MS0011', N'Truyện Kiều', N'Nguyễn Du', N'Văn học', 'STU', 70000, 10, N'Còn')
insert into SACH values ('MS0012', N'Lều chõng', N'Ngô Tất Tố', N'Văn học', 'STU', 50000, 0, N'Hết')
insert into SACH values ('MS0013', N'Sử Việt - 12 khúc tráng ca', N'Dũng Phan', N'Lịch sử', 'STU', 45000, 10, N'Còn')
insert into SACH values ('MS0014', N'Lịch sử Việt Nam', N'Đào Duy Anh', N'Lịch sử', 'STU', 150000, 14, N'Còn')
insert into SACH values ('MS0015', N'Lập trình hướng đối tượng', N'Phạm Anh Tuấn', N'Lập trình', 'STU', 85000, 0, N'Hết')

go
------------------
create proc getlistphieumuon
as
	begin
		select * from PHIEUMUON
	end
go
create proc addphieumuon
	@MaPhieuMuon nchar(10),
	@MaDocGia nchar(10),
	@MaSach nchar(10),
	@NgayMuon datetime,
	@NgayPhaiTra datetime,
	@TinhTrang nvarchar(10)
as
	begin
		insert into PHIEUMUON(MaPhieuMuon,MaDocGia,MaSach,NgayMuon,NgayPhaiTra,TinhTrang)
		values(@MaPhieuMuon,@MaDocGia,@MaSach,@NgayMuon,@NgayPhaiTra,@TinhTrang)
	end
go
create proc editphieumuon
	@MaPhieuMuon nchar(10),
	@MaDocGia nchar(10),
	@MaSach nchar(10),
	@NgayMuon datetime,
	@NgayPhaiTra datetime,
	@TinhTrang nvarchar(10)
as
	begin
		update PHIEUMUON 
		set MaDocGia = @MaDocGia,MaSach = @MaSach,NgayMuon = @NgayMuon,
		NgayPhaiTra = @NgayPhaiTra,TinhTrang = @TinhTrang
		where MaPhieuMuon = @MaPhieuMuon
	end
go
create proc deletephieumuon
@MaPhieuMuon nchar(10)
as
	begin
		delete from PHIEUMUON where MaPhieuMuon = @MaPhieuMuon
	end
go

create proc getListBook
as
begin
	select * from Sach

end
go

-- lấy danh sách các đầu sách theo mã sách
create proc getListBookById(@Masach nchar(10))
as
begin
	select * from Sach
 	where MaSach = @Masach
end 
go
-- lấy danh sách các đầu sách theo tên
create proc getListBookByName(@Tensach nchar(50))
as
begin
	select * from Sach
 	where TenSach = @Tensach
end 
go
-- lấy danh sách các đầu sách theo tac gia
create proc getListBookByAuthor(@Tacgia nchar(30))
as
begin
	select * from Sach
 	where TacGia = @Tacgia
end 
go

-- lấy danh sách các đầu sách theo the loai
create proc getListBookByType(@Theloai nchar(30))
as
begin
	select * from Sach
 	where TheLoai = @Theloai
end 
go
-- lấy danh sách các đầu sách theo nha san xuat
create proc getListBookByPublisher(@NXB nchar(30))
as
begin
	select * from Sach
 	where NhaXuatBan = @NXB
end 
go

-- lấy danh sách các đầu sách theo Gia
create proc getListBookByPrice(@Gia int)
as
begin
	select * from Sach
 	where GiaSach = @Gia
end 
go
-- lấy danh sách các đầu sách theo số lượng 
create proc getListBookByAmount(@Soluong int)
as
begin
	select * from Sach
 	where SoLuong = @Soluong
end 
go

-- lấy danh sách các đầu sách theo Tinh trang
create proc getListBookByState(@Tinhtrang nchar(10))
as
begin
	select * from Sach
 	where TinhTrang = @Tinhtrang
end 
go

-- them 1 dau sach --
create proc insertBook
(@Masach nchar(10),@Tensach nchar(50),@Tacgia nchar(30),@Theloai nchar(30),@Nhaxuatban nchar(50),@Giasach int,@Soluong int, @Tinhtrang nchar(10))
as 
begin 
	insert into Sach(MaSach,TenSach,TacGia,TheLoai,NhaXuatBan,GiaSach,SoLuong,TinhTrang) 
	values(@Masach,@Tensach,@Tacgia,@Theloai,@Nhaxuatban,@Giasach,@Soluong,@Tinhtrang)
end 
go
-- sua thong tin sach
create proc updateBook
(@Masach nchar(10),@Tensach nchar(50),@Tacgia nchar(30),@Theloai nchar(30),@Nhaxuatban nchar(50),@Giasach int,@Soluong int, @Tinhtrang nchar(10))
as 
begin 
	update Sach 
	set TenSach = @Tensach,TacGia = @Tacgia,TheLoai = @Theloai, 
	NhaXuatBan = @Nhaxuatban,GiaSach = @Giasach,SoLuong = @Soluong, TinhTrang = @Tinhtrang
	where MaSach = @Masach
end 
go
-- xoa dau sach

create proc deleteBook
(@Masach nchar(10))
as
begin
	delete from Sach where MaSach = @Masach
end
go

--danh sach phieu tra
create proc getlistphieutra
as
	begin
		select * from PHIEUTRA
	end
go
create proc addphieutra
	@MaPhieuTra nchar(10),
	@MaPhieuMuon nchar(10),
	@NgayTra datetime,
	@TinhTrang nvarchar(10)
as
	begin
		insert into PHIEUTRA(MaPhieuTra,MaPhieuMuon,NgayTra,TinhTrang)
		values(@MaPhieuTra,@MaPhieuMuon,@NgayTra,@TinhTrang)
	end
go
create proc editphieutra
	@MaPhieuTra nchar(10),
	@MaPhieuMuon nchar(10),
	@NgayTra datetime,
	@TinhTrang nvarchar(10)
as
	begin
		update PHIEUTRA 
		set MaPhieuMuon = @MaPhieuMuon,NgayTra = @NgayTra,TinhTrang = @TinhTrang
		where MaPhieuTra = @MaPhieuTra
	end
go
create proc deletephieutra
@MaPhieuTra nchar(10)
as
	begin
		delete from PHIEUTRA where MaPhieuTra = @MaPhieuTra
	end
go
--
-- thêm danh sách đọc giả
create proc getlistDocGia
as
	begin
		select* from DocGia
	end
go
create proc insert_DocGia
(@MaDocGia nchar(10),@TenDangNhap nchar(30),@HoTen nchar(30),@GioiTinh nchar(5),@NamSinh date,@DiaChi nchar(100))
as
	begin
		insert into DocGia(MaDocGia, TenDangNhap ,HoTen ,GioiTinh , NamSinh ,DiaChi)
		values (@MaDocGia ,@TenDangNhap ,@HoTen ,@GioiTinh ,@NamSinh ,@DiaChi )
	end
go
CREATE PROCEDURE Update_DocGia
(@MaDocGia nchar(10),@TenDangNhap nchar(30),@HoTen nchar(30),@GioiTinh nchar(5),@NamSinh date,@DiaChi nchar(100))
AS
BEGIN
	UPDATE  DocGia
	SET  TenDangNhap = @TenDangNhap, HoTen = @HoTen, GioiTinh = @GioiTinh, NamSinh = @NamSinh , DiaChi = @DiaChi
	WHERE MaDocGia = @MaDocGia
END
GO
CREATE PROCEDURE Delete_DocGia
(@MaDocGia nchar(10))
AS
BEGIN
	DELETE FROM DocGia WHERE MaDocGia = @MaDocGia
END
GO
-- tu tang ma doc gia
create function func_NextID(@madocgia nchar(10),@prefix varchar(3),@size int)
returns varchar(10)
as
	begin
		if(@madocgia='')
			set @madocgia=@prefix + REPLICATE(0,@size-LEN(@prefix))
		declare @num_nextUserID int,@nextUserID varchar(6)
		set @madocgia = LTRIM(RTRIM(@madocgia))
		set @num_nextUserID = REPLACE(@madocgia,@prefix,'')+1
		set @size =@size -len(@prefix)
		set @nextUserID = @prefix + REPLICATE(0,@size-LEN(@prefix))
		set @nextUserID = @prefix + RIGHT(REPLICATE(0,@size)+CONVERT(varchar(max),@num_nextUserID),@size)
		return @nextUserID
	end
go
create trigger Tr_NextUserID on [TaiKHoan]
for insert
as
	begin
		DECLARE @madocgia nchar(10)
		set @madocgia = (select top 1 MaDocGia from [TaiKHoan] order by MaDocGia desc)
		UPDATE [TaiKHoan] set MaDocGia = dbo.func_NextID(@madocgia,'ID_',6)
		where MaDocGia = ''
	end
go

insert into TaiKHoan values ('','cuong','123456','Admin')
insert into TaiKHoan values ('','trieuninhngan', '123456','User')
insert into TaiKHoan values ('','nguyenvinhhien', '123456', 'User')
insert into TaiKHoan values ('','nguyenthihongnhung', '123456', 'User')
insert into TaiKHoan values ('','dinhthiphuong', '123456','User')
insert into TaiKHoan values ('','nguyenthibichngoc', '123456', 'User')
insert into TaiKHoan values ('','lethiquynh', '123456', 'User')
insert into TaiKHoan values ('','nguyenminhtri', '123456','User')
insert into TaiKHoan values ('','nguyenquockhanh', '123456', 'User')

--quá hạn trả
select pm.MaDocGia from PhieuMuon as pm
where pm.NgayPhaiTra < GETDATE() 

select pm.MaPhieuMuon,dg.HoTen,pm.MaSach,pm.NgayMuon,pm.NgayPhaiTra,TinhTrang from phieumuon as pm,DocGia as dg
where dg.MaDocGia = pm.MaDocGia and pm.MaPhieuMuon not in
(select pt.MaPhieuMuon from PhieuTra as pt
where pm.MaPhieuMuon = pt.MaPhieuMuon)
go
--đang mượn
create function dangmuonchuatra()
returns table return
select pm.MaPhieuMuon,dg.HoTen,pm.MaSach,pm.NgayMuon,pm.NgayPhaiTra,TinhTrang from phieumuon as pm,DocGia as dg
where dg.MaDocGia = pm.MaDocGia and pm.MaPhieuMuon not in
(select pt.MaPhieuMuon from PhieuTra as pt
where pm.MaPhieuMuon = pt.MaPhieuMuon)
go
--đã trả
create function datra()
returns table return 
select pm.MaPhieuMuon,t.MaPhieuTra,dg.HoTen,pm.MaSach,t.NgayTra,t.TinhTrang from phieumuon as pm,DocGia as dg,phieutra as t
where dg.MaDocGia = pm.MaDocGia and pm.MaPhieuMuon = t.MaPhieuMuon
except
select pm.MaPhieuMuon,t.MaPhieuTra,dg.HoTen,pm.MaSach,t.NgayTra,t.TinhTrang from phieumuon as pm,DocGia as dg,phieutra as t
where dg.MaDocGia = pm.MaDocGia and pm.MaPhieuMuon = t.MaPhieuMuon and pm.MaPhieuMuon not in
(select pt.MaPhieuMuon from PhieuTra as pt
where pm.MaPhieuMuon = pt.MaPhieuMuon)
select * from TaiKHoan


go
--tai khoan
create proc getlisttaikhoan
as
	begin
		select * from TaiKhoan
	end
go

create proc addtaikhoan
	@MaDocGia nchar(10),
	@TenDangNhap nchar(30),
	@MatKhau nchar(30),
	@Quyen varchar(10)
as
	begin
		insert into TaiKHoan(MaDocGia,TenDangNhap,MatKhau,Quyen)
		values(@MaDocGia,@TenDangNhap,@MatKhau,@Quyen)
	end
go
CREATE PROCEDURE Update_taikhoan
	@MaDocGia nchar(10),
	@TenDangNhap nchar(30),
	@MatKhau nchar(30),
	@Quyen varchar(10)
AS
BEGIN
	UPDATE  TaiKHoan
	SET  TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, Quyen = @Quyen
	WHERE MaDocGia = @MaDocGia
END
GO
CREATE PROCEDURE Delete_taikhoan
(@MaDocGia nchar(10))
AS
BEGIN
	DELETE FROM TaiKHoan WHERE MaDocGia = @MaDocGia
END
GO

create proc ListMaDocGia
as
	begin
		select MaDocGia from DocGia
	end
go
create proc ListMaSach
as
	begin
		select masach from Sach
	end
go

create proc dangmuon
as
	begin
		select pm.MaPhieuMuon,dg.HoTen,pm.MaSach,pm.NgayMuon,pm.NgayPhaiTra,TinhTrang from phieumuon as pm,DocGia as dg
		where dg.MaDocGia = pm.MaDocGia and pm.MaPhieuMuon not in
		(select pt.MaPhieuMuon from PhieuTra as pt
		where pm.MaPhieuMuon = pt.MaPhieuMuon)
	end
go