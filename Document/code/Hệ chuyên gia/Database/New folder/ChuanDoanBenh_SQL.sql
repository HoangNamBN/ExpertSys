-- Tạo cơ sở dữ liệu ChuanDoanBenh
Create Database ChuanDoanBenh
On Primary
(
	Name='ChuanDoanBenh', FileName='D:\SQL\ChuanDoanBenh\ChuanDoanBenh.MDF', Size=2MB, MaxSize=Unlimited, FileGrowth=1MB
)
Log On
(
	Name='ChuanDoanBenh_LOG', FileName='D:\SQL\ChuanDoanBenh\ChuanDoanBenh_LOG.LDF', Size=1MB, MaxSize=Unlimited, FileGrowth=1MB
)

-- Tạo bảng SuKien
Create Table SuKien
(
	MaSuKien Int Identity Primary Key,
	TenSuKien Nvarchar(200) Not Null Unique,
	CauHoi Nvarchar(500) Not Null
)
Insert Into SuKien(TenSuKien, CauHoi) Values(N'Ho', N'Bạn có ho không?')
Insert Into SuKien(TenSuKien, CauHoi) Values(N'Chảy nước mũi', N'Bạn có bị chảy nước mũi không?')
Insert Into SuKien(TenSuKien, CauHoi) Values(N'Nghẹt mũi', N'Bạn có bị nghẹt mũi không?')
-- Tạo bảng Luat
Create Table Luat
(
	MaLuat Int Identity Primary Key,
	TenLuat Nvarchar(200) Not Null Unique,
	HeSoTinCay Decimal(3,2) Default(0),
	Constraint chk_HeSoTinCay_Luat Check(HeSoTinCay>=0 And HeSoTinCay<=1)
)
-- Tạo bảng LuatSuKien
Create Table LuatSuKien
(
	MaSuKien Int References SuKien(MaSuKien),
	MaLuat Int References Luat(MaLuat),
	HeSoTinCay Decimal(3,2) Not Null,
	Constraint pk_LuatSuKien Primary Key(MaSuKien, MaLuat),
	Constraint chk_HeSoTinCay_LuatSuKien Check(HeSoTinCay>0 And HeSoTinCay<=1)
)
Create Table NguoiDung
(
	ID Int Identity Primary Key,
	TenDangNhap Varchar(50) Not Null Unique,
	MatKhau Varchar(30) Not Null,
	HoTen Nvarchar(100) Not Null,
	Quyen Bit Default(0)
)
Select ID, TenDangNhap, MatKhau, HoTen, Case Quyen When 0 Then N'Chuyên gia' When 1 Then N'Quản trị viên' End As 'Quyen' From NguoiDung
Create Trigger t_Tinh_HeSoTinCay_Luat
On LuatSuKien
For Insert, Update, Delete
As
Begin
	Declare @MaLuat Int
	Set @MaLuat = Null
	Declare @HeSoTinCay Decimal(3,2)
	Select @MaLuat = MaLuat From Inserted
	If(@MaLuat Is Null)
		Select @MaLuat = MaLuat From Deleted
	Set @HeSoTinCay = Coalesce((Select Sum(HeSoTinCay) From LuatSuKien Where MaLuat = @MaLuat), 0)
	If(@HeSoTinCay>1)
		Rollback Transaction
	Else
		Update Luat Set HeSoTinCay = @HeSoTinCay Where MaLuat = @MaLuat
End