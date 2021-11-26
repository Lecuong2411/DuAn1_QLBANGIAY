


INSERT INTO NhaCungCap(MaNCC, NguoiCC, congTyCC,SDT,DiaChi,GhiChu)
VALUES
('CC01',N'Lê Văn Cường','THE LANG',0323337878,N'QUẢNG CHÂU','XỊN'),
('CC02',N'LÊ HỒNG TUYỂN','XINGANG',0366637878,N'QUẢNG CHÂU','XỊN'),
('CC03',N'LÃ ĐỨC ANH','TY VI',0666337878,N'MĨ','XỊN'),
('CC04',N'NGÔ TRUNG KIÊN','THE SS',0328555878,N'HỒNG CÔNG','XỊN'),
('CC05',N'HỒ THẾ TRUNG','ANH',0328337999,N'ANH','XỊN');


INSERT INTO DanhMuc(MaDanhMuc, TenDanhMuc, GhiChu,TrangThai)
VALUES
('DM01','ĐÁ BÓNG','ÊM CHÂN', 1),
('DM02','BÓNG RỔ','ÊM CHÂN', 1);


INSERT INTO SanPham(MaSP, TenSP, ThuongHieu,TrangThai,MaDanhMuc,MaNCC)
VALUES
('SP001','BLENXIAGA','NIKE',1,'DM01','CC03'),
('SP002','MECHOTIEN','MEMUA',1,'DM01','CC02'),
('SP003','QUAY','BATA',1,'DM02','CC01'),
('SP004','THEDUC','THƯỢNG ĐÌNH',1,'DM02','CC05'),
('SP005','TRETRAU','CUGI',1,'DM01','CC04');


INSERT INTO Size(MaSize, SizeSp, ChieuDaiChan,TrangThai)
VALUES
('SZ01',38,26,1),
('SZ02',42,30,1),
('SZ03',41,29,1),
('SZ04',40,28,1),
('SZ05',39,27,1);

INSERT INTO LoaiCoGiay(MaCo,LoaiCoGiaySP,TrangThai) 
VALUES 
('C01','CỔ CAO',1),
('C02','CỔ THẤP',1);

INSERT INTO ChatLieu(MaChatLieu,ChatLieuSP,TrangThai) 
VALUES 
('CL01','DA BÒ',1),
('CL02','SẮT',1),
('CL03','NHỰA',1),
('CL04','DA CÁ XẤU',1),
('CL05','DA TRÂU',1);

INSERT INTO Color(MaClr,ColorSP,TrangThai) 
VALUES 
('M01','VÀNG',1),
('M02','ĐỎ',1),
('M03','XANH',1),
('M04','TRẮNG',1),
('M05','ĐEN',1);

INSERT INTO ChiTietSanPham(MaCTSP,MaCo,MaChatLieu,GhiChu,Mota,MaQR,soluong,giaban,GiaNhap,TrangThai,MaSize,MaCLR,MaSP) 
VALUES
('CTSP01','C01','CL01',N'ĐẸP','ĐI KHÁ ỔN','0123456789012',10,300000,10000,1,'SZ01','M01','SP001'),
('CTSP02','C02','CL02',N'ĐẸP','ĐI KHÁ ỔN','0182828288288',10,300000,10000,1,'SZ02','M02','SP002'),
('CTSP03','C01','CL03',N'ĐẸP','ĐI KHÁ ỔN','0128888999999',10,300000,10000,1,'SZ03','M03','SP003'),
('CTSP04','C02','CL04',N'ĐẸP','ĐI KHÁ ỔN','9299999999999',10,300000,10000,1,'SZ04','M04','SP004'),
('CTSP05','C01','CL05',N'ĐẸP','ĐI KHÁ ỔN','0000000929299',10,300000,10000,1,'SZ05','M05','SP005');



INSERT INTO Images(MaImage,MaCTSP,Images,TrangThai) 
VALUES 
('IMG01','CTSP01',N'CHƯA CÓ',1),
('IMG02','CTSP02',N'CHƯA CÓ',1),
('IMG03','CTSP03',N'CHƯA CÓ',1),
('IMG04','CTSP04',N'CHƯA CÓ',1),
('IMG05','CTSP05',N'CHƯA CÓ',1);


INSERT INTO ChucVu (MaChucVu,Roles,TrangThai)
VALUES 
('CV01',1,1),
('CV02',1,1);

INSERT INTO NhanVien(MaNv,TenNv,Sdt,DiaChi,Email,MatKhau,GioiTinh,NamSinh,MaChucVu,HinhAnh,TrangThai)
VALUES 
('NV01',N'ĐỖ XUÂN AN','03892892839',N'CẦU GIẤY','xuanan@fpt.edu.vn','123',1,2002,'CV01','CHƯA CÓ',1),
('NV02',N'HỒ THẾ TRUNG','03892891111',N'CẦU GIẤY','TRUNG@fpt.edu.vn','123',0,2005,'CV02','CHƯA CÓ',1),
('NV03',N'GIÀNG A XÀ','03892893333',N'CẦU GIẤY','XA@fpt.edu.vn','123',0,2004,'CV01','CHƯA CÓ',1),
('NV04',N'LÊ ĐÌNH NGHĨA','03892890000',N'CẦU GIẤY','NGHIA@fpt.edu.vn','123',0,2002,'CV02','CHƯA CÓ',1),
('NV05',N'NGÔ TRUNG KIÊN','03892899999',N'CẦU GIẤY','KIEN@fpt.edu.vn','123',1,2003,'CV01','CHƯA CÓ',1);


INSERT INTO history(MaHis,MaCTSP,MaNV,NgayNhap)
VALUES
('HIS01','CTSP01','NV01','01-01-2021'),
('HIS02','CTSP02','NV02','01-01-2021'),
('HIS03','CTSP03','NV03','01-01-2021'),
('HIS04','CTSP04','NV04','01-01-2021'),
('HIS05','CTSP05','NV05','01-01-2021');


INSERT INTO KhachHang(MaKh,TenKh,Sdt)
VALUES
('KH01','LÊ VĂN A','03892839289'),
('KH02','LÊ VĂN B','03892839000'),
('KH03','LÊ VĂN C','03892839999');

INSERT INTO HoaDon(MaHd,Tongtien,TienNhan,GhiChu,MaKH,MaNV,TrangThaiHd,MaVouCher,thoigian)
VALUES 
('HD01',300000,400000,'HOÀN THÀNH','KH01','NV03',1,'VC01','2021-11-11'),
('HD02',300000,600000,'HOÀN THÀNH','KH02','NV01',1,'VC02','2021-11-29'),
('HD03',300000,500000,'HOÀN THÀNH','KH03','NV02',1,'VC01','2021-11-21');

INSERT INTO HoaDonChiTiet(MaHd,MaCTSP,DonGia,TrangThai)
VALUES 
('HD01','CTSP03',300000,1),
('HD02','CTSP01',300000,1),
('HD03','CTSP02',300000,1);

insert into Voucher (MaVouCher,Vouchers,NSD,HSD,SoLuong,SoLuongDSD,MenhGia,TrangThai,GhiChu)
values 
('VC01','039182738','11-01-2021','11-30-2021',10,10,20000,1,'merry'),
('VC02','090082738','11-01-2021','11-30-2021',10,10,30000,1,'happy'),
('VC03','039111738','11-01-2021','11-20-2021',10,10,20000,1,'merry');


insert into ProductBack(MaPB,ProductStatus,TrangThai)
values
('PB1',1,1),
('PB2',0,0);