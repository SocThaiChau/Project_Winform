

--Hoc sinh
CREATE TABLE HocSinh3 (
 Mahocsinh int not null,
 Ten varchar(100) not null,
 Diachi varchar(255) not null,
 Ngaysinh datetime not null,
 Cmnd varchar(100) not null,
 Email varchar(100) not null,
 SoDT varchar(100) not null,
);

select * from HocSinh3

INSERT INTO HocSinh3 (Mahocsinh, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (1, 'Thai', 'AG', '1/2/2002','1', 'thai@gmail.com', '0313232424');
INSERT INTO HocSinh3 (Mahocsinh, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (2, 'Hau', 'KG', '1/3/2002','1', 'hau@gmail.com', '0313233562');
INSERT INTO HocSinh3 (Mahocsinh, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (3, 'Dang', 'BL', '4/1/2002','1', 'dang@gmail.com', '0313235635');
INSERT INTO HocSinh3 (Mahocsinh, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (4, 'Hien', 'LA', '1/5/2002','1', 'hien@gmail.com', '0313232582');
INSERT INTO HocSinh3 (Mahocsinh, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (5, 'Trong', 'BP', '1/7/2002','1', 'trong@gmail.com', '0313233501');

-- Giao vien
CREATE TABLE GiaoVien3 (
 Magiaovien int not null,
 Ten varchar(100) not null,
 Diachi varchar(255) not null,
 Ngaysinh datetime not null,
 Cmnd varchar(100) not null,
 Email varchar(100) not null,
 SoDT varchar(100) not null,
);

select * from GiaoVien3

INSERT INTO GiaoVien3 (Magiaovien, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (1, 'Thai', 'AG', '1/2/2002','1', 'thai@gmail.com', '0313232424');
INSERT INTO GiaoVien3 (Magiaovien, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (2, 'Hau', 'KG', '1/3/2002','1', 'hau@gmail.com', '0313233562');
INSERT INTO GiaoVien3 (Magiaovien, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (3, 'Dang', 'BL', '4/1/2002','1', 'dang@gmail.com', '0313235635');
INSERT INTO GiaoVien3 (Magiaovien, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (4, 'Hien', 'LA', '1/5/2002','1', 'hien@gmail.com', '0313232582');
INSERT INTO GiaoVien3 (Magiaovien, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)
VALUES (5, 'Trong', 'BP', '1/7/2002','1', 'trong@gmail.com', '0313233501');
