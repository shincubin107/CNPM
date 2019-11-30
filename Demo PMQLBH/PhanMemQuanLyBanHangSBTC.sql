create database PhanMemQuanLyBanHangSBTC
use PhanMemQuanLyBanHangSBTC

create table TaiKhoan
(
	Username nvarchar(100) primary key,
	Password nvarchar(100) not null default 1,
	TenUserHienThi nvarchar(100) default N'Chưa đặt tên',
	ChucVu nvarchar(100),
	LoaiTaiKhoan int, --0 là admin , 1 là nhân viên
	TrangThai nvarchar (20) default 'On'
)

create table FoodDrink
(
	Id int primary key,
	TenFoodDrink nvarchar(100) default N'Chưa đặt tên',
	TenDanhMuc nvarchar(100),
	Gia float default 0,
	TrangThai nvarchar(20)
)

create table Bill
(
	Id int primary key,
	NgayLapBill datetime default getdate(),
	HinhThucThanhToan nvarchar(100),
	TongBill float,
	GiamGia float,
	NhanVienLap nvarchar(100)

	foreign key (NhanVienLap) references TaiKhoan(Username),
)

create table ChiTietBill
(
	Id int identity primary key,
	IdBill int,
	IdFD int,
	TenFoodDrink_CTB nvarchar(100),
	SoLuong int default 0,
	DonGia_CTB float,
	GhiChu nvarchar(100) default ''
	
	foreign key (IdBill) references Bill(Id),
)
ALTER TABLE ChiTietBill 
  ADD CONSTRAINT fk_IdFD 
  FOREIGN KEY (IdFD) 
  REFERENCES FoodDrink(Id) 
  ON UPDATE CASCADE;

select TenFoodDrink from FoodDrink where TenFoodDrink = 'Cafe Sữa'

select TenFoodDrink_CTB, SoLuong, DonGia_CTB from ChiTietBill where IdBill in (select Id from Bill where NgayLapBill = '2019-11-05 00:00:00.000')
select NgayLapBill from Bill where NgayLapBill = '2019-11-05 00:00:00.000'

create view viewBill as select TenFoodDrink_CTB as [Món ăn đã bán], SoLuong as [Số Lượng], DonGia_CTB as [Đơn Giá] from ChiTietBill where IdBill in (select Id from Bill where NgayLapBill = '2019-11-05 00:00:00.000') 
select [Món ăn đã bán] ,sum([Số Lượng]) as [Số Lượng], [Đơn Giá]   from viewBill group by [Món ăn đã bán],  [Đơn Giá]
select sum(sum(TongBill), sum(GiamGia)) from Bill where NgayLapBill = '2019-11-05 00:00:00.000'



create table GioCongNhanVien
(
	username nvarchar(100) primary key,
	ngay1 int default 0,
	ngay2 int default 0,
	ngay3 int default 0,
	ngay4 int default 0,
	ngay5 int default 0,
	ngay6 int default 0,
	ngay7 int default 0,
	ngay8 int default 0,
	ngay9 int default 0,
	ngay10 int default 0,
	ngay11 int default 0,
	ngay12 int default 0,
	ngay13 int default 0,
	ngay14 int default 0,
	ngay15 int default 0,
	ngay16 int default 0,
	ngay17 int default 0,
	ngay18 int default 0,
	ngay19 int default 0,
	ngay20 int default 0,
	ngay21 int default 0,
	ngay22 int default 0,
	ngay23 int default 0,
	ngay24 int default 0,
	ngay25 int default 0,
	ngay26 int default 0,
	ngay27 int default 0,
	ngay28 int default 0,
	ngay29 int default 0,
	ngay30 int default 0,
	ngay31 int default 0,
	LuongTheoGio int default 20000,
	TongGioLam int default 0

	foreign key (username) references TaiKhoan(Username),
)


create table LichLam
(
	username nvarchar(100) primary key,
	ngay1 nvarchar(100) default '',
    ngay2 nvarchar(100) default '',
	ngay3 nvarchar(100) default '',
    ngay4 nvarchar(100) default '',
	ngay5 nvarchar(100) default '',
    ngay6 nvarchar(100) default '',
	ngay7 nvarchar(100) default '',
    ngay8 nvarchar(100) default '',
	ngay9 nvarchar(100) default '',
    ngay10 nvarchar(100) default '',
	ngay11 nvarchar(100) default '',
    ngay12 nvarchar(100) default '',
	ngay13 nvarchar(100) default '',
    ngay14 nvarchar(100) default '',
	ngay15 nvarchar(100) default '',
    ngay16 nvarchar(100) default '',
	ngay17 nvarchar(100) default '',
    ngay18 nvarchar(100) default '',
	ngay19 nvarchar(100) default '',
    ngay20 nvarchar(100) default '',
	ngay21 nvarchar(100) default '',
    ngay22 nvarchar(100) default '',
	ngay23 nvarchar(100) default '',
    ngay24 nvarchar(100) default '',
	ngay25 nvarchar(100) default '',
    ngay26 nvarchar(100) default '',
	ngay27 nvarchar(100) default '',
    ngay28 nvarchar(100) default '',
	ngay29 nvarchar(100) default '',
    ngay30 nvarchar(100) default '',
	ngay31 nvarchar(100) default '',	

	foreign key (username) references TaiKhoan(Username),
)

select LichLamNV.username from LichLamNV,TaiKhoan where TaiKhoan.Username=LichLamNV.username and TaiKhoan.TrangThai='On'


create table PhieuNhap
(
	MaPhieu nvarchar(20) primary key,
	NgayLapPhieu datetime,
	NCC nvarchar(100),
	DiaChiNCC nvarchar(100),
	NhanVienLap nvarchar(100)
)
ALTER TABLE PhieuNhap ADD CONSTRAINT fk_NhanVienLap FOREIGN KEY (NhanVienLap) REFERENCES TaiKhoan(Username) 

create table ChiTietPhieuNhap
(
	Id int identity primary key,
	MaPhieu nvarchar(20),
	TongTienPhieuNhap float,
	TenHang nvarchar(100),
	SoLuong int,
	DonViTinh nvarchar(20),
	DonGia float,
	ThanhTien float

	foreign key (MaPhieu) references PhieuNhap(MaPhieu),
)


update LichLam set ngay3 = 'MBC'  where LichLam.username in (select Username from TaiKhoan where TenUserHienThi = N'Thằng Sena')
update LichLam set ngay" + Convert.ToString(Convert.ToInt32(x)-1) + " = @ngay" + Convert.ToString(Convert.ToInt32(x)-1) + " where LichLam.username in (select Username from TaiKhoan where TenUserHienThi = N'" + tenNV + "') 