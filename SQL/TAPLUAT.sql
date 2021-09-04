-- =============================================
-- Create database template
-- =============================================
USE master
GO

-- Drop the database if it already exists
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'DuDoanKetQua'
)
DROP DATABASE DuDoanKetQua
GO

CREATE DATABASE DuDoanKetQua
GO

USE DuDoanKetQua
GO

CREATE TABLE TAPLUAT
(
MaLuat int ,
ChamChi nvarchar(10),
Ktn nvarchar(10),
DoKho nvarchar(10),
KetQua nvarchar(10),
PRIMARY KEY(MaLuat),
UNIQUE (ChamChi, Ktn, DoKho, KetQua)
)
GO

--ChamChi : Cao, TB, Thấp
--
--Ktn : Tốt, TB, Kém
--
--DoKho : Khó, Vừa, Dễ
--
--KetQua : Tốt, TB, Kém
--

INSERT INTO TAPLUAT
VALUES(1, N'Cao', N'Tốt', N'Khó', N'Tốt'),
		(2, N'Cao', N'Tốt', N'Vừa', N'Tốt'),
		(3, N'Cao', N'Tốt', N'Dễ', N'Tốt'),
		(4, N'Cao', N'TB', N'Khó', N'TB'),
		(5, N'Cao', N'TB', N'Vừa', N'Tốt'),
		(6, N'Cao', N'TB', N'Dễ', N'Tốt'),
		(7, N'Cao', N'Kém', N'Khó', N'TB'),
		(8, N'Cao', N'Kém', N'Vừa', N'TB'),
		(9, N'Cao', N'Kém', N'Dễ', N'Tốt'),
		(10, N'TB', N'Tốt', N'Khó', N'TB'),
		(11, N'TB', N'Tốt', N'Vừa', N'Tốt'),
		(12, N'TB', N'Tốt', N'Dễ', N'Tốt'),
		(13, N'TB', N'TB', N'Khó', N'TB'),
		(14, N'TB', N'TB', N'Vừa', N'TB'),
		(15, N'TB', N'TB', N'Dễ', N'Tốt'),
		(16, N'TB', N'Kém', N'Khó', N'Kém'),
		(17, N'TB', N'Kém', N'Vừa', N'TB'),
		(18, N'TB', N'Kém', N'Dễ', N'TB'),
		(19, N'Thấp', N'Tốt', N'Khó', N'TB'),
		(20, N'Thấp', N'Tốt', N'Vừa', N'TB'),
		(21, N'Thấp', N'Tốt', N'Dễ', N'Tốt'),
		(22, N'Thấp', N'TB', N'Khó', N'Kém'),
		(23, N'Thấp', N'TB', N'Vừa', N'Kém'),
		(24, N'Thấp', N'TB', N'Dễ', N'TB'),
		(25, N'Thấp', N'Kém', N'Khó', N'Kém'),
		(26, N'Thấp', N'Kém', N'Vừa', N'Kém'),
		(27, N'Thấp', N'Kém', N'Dễ', N'	Kém')


SELECT * FROM TAPLUAT






