Create Database Student_Management_System
Use Student_Management_System


create table tbl_Students(
StudentID int primary key identity(1,1),
Registration_No nvarchar(max),
Roll_No int,
Student_Name nvarchar(max),
Father_Name nvarchar(max),
Student_Contact nvarchar(max),
Father_Contact nvarchar(max),
Class_Name nvarchar(max),
Email nvarchar(max),
Age nvarchar(max),
Address nvarchar(max)
)

select *from tbl_Students

