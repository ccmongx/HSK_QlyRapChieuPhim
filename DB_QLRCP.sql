-- Tạo khóa ngoại cho bảng Nhân Viên
ALTER TABLE dbo.tblNhanVien ADD CONSTRAINT FK_NhanVien_Rap
FOREIGN KEY (sMaRap) REFERENCES dbo.tblRap(sMaRap);
go

-- Tạo khóa ngoại cho bảng Phim
ALTER TABLE dbo.tblPhim ADD CONSTRAINT FK_Phim_NuocSX  
FOREIGN KEY (sMaNuocSX) REFERENCES dbo.tblNuocSX(sMaNuocSX);
go

ALTER TABLE dbo.tblPhim ADD CONSTRAINT FK_Phim_HangSX
FOREIGN KEY (sMaHangSX) REFERENCES dbo.tblHangSX(sMaHangSX);
go

ALTER TABLE dbo.tblPhim ADD CONSTRAINT FK_Phim_TheLoai
FOREIGN KEY (sMaTheLoai) REFERENCES dbo.tblTheLoai(sMaTheLoai);
go

-- Tạo khóa ngoại cho bảng Lịch Chiếu
ALTER TABLE dbo.tblLichChieu ADD CONSTRAINT FK_LichChieu_Phim
FOREIGN KEY (sMaPhim) REFERENCES dbo.tblPhim(sMaPhim);
go

ALTER TABLE dbo.tblLichChieu ADD CONSTRAINT FK_LichChieu_Rap
FOREIGN KEY (sMaRap) REFERENCES dbo.tblRap(sMaRap);
go

ALTER TABLE dbo.tblLichChieu ADD CONSTRAINT FK_LichChieu_Phong
FOREIGN KEY (sMaPhong) REFERENCES dbo.tblPhongChieu(sMaPhong); 
go

ALTER TABLE dbo.tblLichChieu ADD CONSTRAINT FK_LichChieu_GioChieu
FOREIGN KEY (sMaGioChieu) REFERENCES dbo.tblGioChieu(sMaGioChieu);
go

-- Tạo khóa ngoại cho bảng Phòng Chiếu
ALTER TABLE dbo.tblPhongChieu ADD CONSTRAINT FK_PhongChieu_Rap  
FOREIGN KEY (sMaRap) REFERENCES dbo.tblRap(sMaRap);
go

-- Tạo khóa ngoại cho bảng Vé
ALTER TABLE dbo.tblVe ADD CONSTRAINT FK_Ve_LichChieu
FOREIGN KEY (sMaShow) REFERENCES dbo.tblLichChieu(sMaShow);
go

-- Tạo khóa ngoại cho bảng Trạng Thái Ghế
ALTER TABLE dbo.tblTrangThaiGhe ADD CONSTRAINT FK_TTGhe_Phong
FOREIGN KEY (sMaPhong) REFERENCES dbo.tblPhongChieu(sMaPhong);
go

ALTER TABLE dbo.tblTrangThaiGhe ADD CONSTRAINT FK_TTGhe_Rap  
FOREIGN KEY (sMaRap) REFERENCES dbo.tblRap(sMaRap);
go

-- Tạo khóa ngoại cho bảng Nhân Viên
ALTER TABLE dbo.tblNhanVien ADD CONSTRAINT FK_TTGhe_Rap  
FOREIGN KEY (sMaRap) REFERENCES dbo.tblRap(sMaRap);
go


-- Cập nhật tổng số phòng một rạp khi có phòng mới
alter trigger SoPhongRap 
on tblPhongChieu after insert as
begin
update tblRap
set iSoPhong = iSoPhong +( select count(sMaPhong) from inserted where sMaRap= tblRap.sMaRap) from
tblRap join inserted on tblRap.sMaRap =inserted.sMaRap
end 
go

-- Cập nhật tổng số ghế một rạp khi có phòng mới
alter trigger TongSoGheRap on tblPhongChieu after insert as
begin 
update tblRap
set iTongSoGhe = tblRap.iTongSoGhe +(select iTongSoGhe from inserted where sMaRap =
tblRap.sMaRap) from tblRap join inserted on tblRap.sMaRap=inserted.sMaRap
end
go

-- Cập nhật tổng số phòng một rạp sau khi một phòng bị xóa
alter trigger XoaSoPhongRap 
on tblPhongChieu for delete as
begin
update tblRap
set iSoPhong = iSoPhong -( select count(sMaPhong) from deleted where sMaRap= tblRap.sMaRap) from
tblRap join deleted on tblRap.sMaRap =deleted.sMaRap
end 
go

-- Cập nhật tổng số ghế một rạp sau khi một phòng bị xóa
alter trigger XoaTongSoGheRap on tblPhongChieu for delete as
begin 
update tblRap
set iTongSoGhe = tblRap.iTongSoGhe -(select iTongSoGhe from deleted where sMaRap =tblRap.sMaRap)
from tblRap join deleted on tblRap.sMaRap =deleted.sMaRap
end
go

-- Cập nhật tổng số ghế một rạp sau khi sửa số liệu một phòng
alter trigger SuaTongSoGhe on tblPhongChieu after update as
begin 
update tblRap
set iTongSoGhe = tblRap.iTongSoGhe +(select iTongSoGhe from inserted where sMaRap =tblRap.sMaRap
) - (select iTongSoGhe from deleted where sMaRap =tblRap.sMaRap) from tblRap join deleted on
tblRap.sMaRap =deleted.sMaRap
end
go

-- Cập nhật tổng số ghế một phòng sau khi một ghế được thêm
alter trigger TongSoGhePC on tblTrangThaiGhe after insert as
begin 
update tblPhongChieu
set iTongSoGhe = tblPhongChieu.iTongSoGhe +(select count (sMaGhe) from inserted where sMaPhong
=tblPhongChieu.sMaPhong) from tblPhongChieu join inserted on
tblPhongChieu.sMaPhong=inserted.sMaPhong
end
go

-- Cập nhật tổng số ghế một phòng sau khi một ghế bị xóa
alter trigger XoaTongSoGhePC on tblTrangThaiGhe for delete as
begin 
update tblPhongChieu
set iTongSoGhe = tblPhongChieu.iTongSoGhe -(select count (sMaGhe) from deleted where sMaPhong
=tblPhongChieu.sMaPhong) from tblPhongChieu join deleted on tblPhongChieu.sMaPhong
=deleted.sMaPhong
end
go

alter trigger DatVe on tblVe AFTER INSERT AS 
BEGIN UPDATE tblTrangThaiGhe
SET sTrangThai= N'Sold'
From tblTrangThaiGhe join inserted on tblTrangThaiGhe.sMaGhe = inserted.sMaGhe
where tblTrangThaiGhe.sMaGhe = inserted.sMaGhe
END
go

alter trigger HuyVe on tblVe AFTER DELETE AS 
BEGIN UPDATE tblTrangThaiGhe
SET sTrangThai= N'Available'
From tblTrangThaiGhe join deleted on tblTrangThaiGhe.sMaGhe = deleted.sMaGhe
where tblTrangThaiGhe.sMaGhe = deleted.sMaGhe
END 
go

-- Cập nhật tổng tiền khi có thêm vé được bán
alter trigger TongTienist on tblVe AFTER INSERT AS 
BEGIN UPDATE tblLichChieu
SET fTongTien = (fGiaVe * iSoVeDaBan) FROM tblLichChieu join inserted on
tblLichChieu.sMaShow = inserted.sMaShow
WHERE tblLichChieu.sMaShow = inserted.sMaShow
END
go

-- Cập nhật tổng tiền khi có vé bị hủy
alter trigger TongTiendlt on tblVe AFTER DELETE AS 
BEGIN UPDATE tblLichChieu
SET fTongTien = (fGiaVe * iSoVeDaBan) FROM tblLichChieu join deleted on
tblLichChieu.sMaShow = deleted.sMaShow
WHERE tblLichChieu.sMaShow = deleted.sMaShow
END
go

-- Cập nhật tổng tiền khi có vé thay đổi phim
alter trigger TongTienudt on tblVe AFTER UPDATE AS 
BEGIN UPDATE tblLichChieu
SET fTongTien = (fGiaVe * iSoVeDaBan) FROM tblLichChieu join inserted on
tblLichChieu.sMaShow = inserted.sMaShow
WHERE tblLichChieu.sMaShow = inserted.sMaShow
END
go

-- Cập nhật tổng thu khi show được cập nhật
alter trigger TongThuupdate on tblLichChieu AFTER UPDATE AS 
BEGIN UPDATE tblPhim
SET fTongThu = (select SUM(fTongTien) from tblPhim join inserted on tblPhim.sMaPhim =
inserted.sMaPhim
GROUP BY tblPhim.sMaPhim)
END
go

-- Cập nhật tổng tiền khi có một show bị hủy
alter trigger TongThudelete on tblLichChieu AFTER DELETE AS 
BEGIN UPDATE tblPhim
SET fTongThu = (select SUM(fTongTien) from tblPhim join deleted on tblPhim.sMaPhim =
deleted.sMaPhim
GROUP BY tblPhim.sMaPhim)
END
go

-- Nhân viên phải trên 18 tuổi
CREATE TRIGGER trg_NhanVien_CheckTuoi
ON dbo.tblNhanVien 
FOR INSERT, UPDATE  
AS
BEGIN
  DECLARE @NgaySinh DATE
  
  SELECT @NgaySinh = i.dNgaySinh 
  FROM inserted AS i
  
  IF (DATEDIFF(YEAR, @NgaySinh, GETDATE()) < 18)
  BEGIN
    RAISERROR ('Tuổi nhân viên phải lớn hơn 18!', 16, 1)
    ROLLBACK TRANSACTION
  END
END
go

-- Thêm dữ liệu
