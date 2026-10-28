create database DuLieu_ThietBi;

use DuLieu_ThietBi;

create table ThietBi
(
	MaThietBi NVARCHAR(10) NOT NULL,
	TenThietBi NTEXT NOT NULL,
	DonGia NVARCHAR(12) NOT NULL
	
	PRIMARY KEY (MaThietBi)
)

INSERT INTO ThietBi VALUES
('TB001', N'Máy tính xách tay DELL',15000000),
('TB002', N'Máy in HP laserJet',5500000),
('TB003', N'Màn hình samsung',3800000),
('TB004', N'Bàn phím cơ Logitech',1200000),
('TB005', N'Chuột không dây',450000)

select * from ThietBi