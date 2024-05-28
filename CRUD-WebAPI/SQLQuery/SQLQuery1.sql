Create Table Mobile
(
MobileId int not null identity(1,1),
Name nvarchar(50) not null,
Model nvarchar(50) not null,
NoOfSim int not null,
ManufacturedBy nvarchar(100) not null,
SupplierName nvarchar(50) not null
)

select*from Mobile

Create Procedure Mobiles
(
@name nvarchar(50) ,
@model nvarchar (50),
@noOfSim int,
@manufacturedBy nvarchar(100),
@supplierName nvarchar(50)
)
as
begin
Insert into [dbo].[Mobile]
([Name],[Model],[NoOfSim],[ManufacturedBy],[SupplierName])

Values
      (
         @name,
         @model,
         @noOfSim,
         @manufacturedBy,
         @supplierName
      )

select*from Mobile
end

exec Mobiles

alter procedure Mobupdate
(

@name nvarchar(50),
@model nvarchar(50)

)

as 
begin
update Mobile
set
Model=@model
where Name=@name

select*from Mobile
end

exec Mobupdate '',''

create procedure MobDel
(
@MobileId int
)

as
begin
Delete from Mobile
where MobileId=@MobileId

select*from Mobile
end

exec MobDel 

Create procedure Showall
as
begin
select*from Mobile
end
exec showall