create database PhanMemQuanLyBanHangSBTC
use PhanMemQuanLyBanHangSBTC

create table TaiKhoan
(
	Username nvarchar(100) primary key,
	Password nvarchar(100) not null default 1,
	TenUserHienThi nvarchar(100) default N'Chưa đặt tên',
	ChucVu nvarchar(100),
	LoaiTaiKhoan int not null default 1 --0 là admin , 1 là nhân viên
)

create table FoodDrink
(
	Id int primary key,
	TenFoodDrink nvarchar(100) default N'Chưa đặt tên',
	TenDanhMuc nvarchar(100),
	Gia float default 0
)

create table Bill
(
	Id int primary key,
	NgayLapBill datetime default getdate(),
)

create table ChiTietBill
(
	Id int identity primary key,
	IdBill int,
	TenFoodDrink_CTB nvarchar(100),
	SoLuong int default 0,
	DonGia_CTB float
	
	foreign key (IdBill) references Bill(Id),

)


alter table Bill add HinhThucThanhToan nvarchar(100)
alter table Bill add TongBill float
alter table FoodDrink add TrangThai nvarchar(100)
alter table Bill drop column NhanVienLap

alter table Bill add GiamGia float
alter table Bill add NhanVienLap nvarchar(100)

select TenFoodDrink from FoodDrink where TenFoodDrink = 'Cafe Sữa'

select TenFoodDrink_CTB, SoLuong, DonGia_CTB from ChiTietBill where IdBill in (select Id from Bill where NgayLapBill = '2019-11-05 00:00:00.000')
select NgayLapBill from Bill where NgayLapBill = '2019-11-05 00:00:00.000'

create view viewBill as select TenFoodDrink_CTB as [Món ăn đã bán], SoLuong as [Số Lượng], DonGia_CTB as [Đơn Giá] from ChiTietBill where IdBill in (select Id from Bill where NgayLapBill = '2019-11-05 00:00:00.000') 
select [Món ăn đã bán] ,sum([Số Lượng]) as [Số Lượng], [Đơn Giá]   from viewBill group by [Món ăn đã bán],  [Đơn Giá]
select sum(sum(TongBill), sum(GiamGia)) from Bill where NgayLapBill = '2019-11-05 00:00:00.000'
