go 
Use master 
go 

if exists(select * from sys.databases where name="TP1_Pokemon")
BEGIN  
	DROP DATABASE TP1_Pokemon 
END
Create DATABASE TP1_Pokemon 

GO 
USE TP1_Pokemon 
GO 
 
 EXEC sp_configure filestream_access_level, 2 RECONFIGURE 

 ALTER DATABASE TP1_Pokemon 
 ADD FILEGROUP FG_Images_6216948 CONTAINS FILESTREAM;
 GO 
 ALTER DATABASE TP1_Pokemon 
 ADD FILE (  
	NAME = FG_Images_6216948,  
	FILENAME = 'C:\EspaceLabo\FG_Images_6216948'
)
 TO FILEGROUP FG_Images_6216948 
 GO 