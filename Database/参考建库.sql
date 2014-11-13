create database ClothesFirm;

use ClothesFirm;

create table Store(
StoreID char(8),
ManagerID char(8),
StoreName nvarchar(50),
StoreLocation nvarchar(20),
StoreAddress nvarchar(100),
StorePhone nvarchar(20),
primary key(StoreID)
);

create table Staff(
StaffID char(8),
StoreID char(8),
StaffName nvarchar(50),
StaffSalary int,
StaffPosition nvarchar(8),
StaffPhone nvarchar(20),
primary key(StaffID)
);

create table Member(
MemberID char(8),
MemberName nvarchar(50),
MemberGender nvarchar(8),
MemberAddress nvarchar(100),
MemberPhone nvarchar(20),
MemberQQ nvarchar(11),
primary key(MemberID)
);

create table Clothes(
ClothesID char(8),
ClothesSize nvarchar(8),
ClothesPrice int,
BrandID char(8),
primary key(ClothesID)
);

create table Supplier(
SupplierID char(8),
SupplierName nvarchar(50),
SupplierAddress nvarchar(100),
primary key(SupplierID)
);

create table ContractInformation(
ContractID char(8),
StoreID char(8),
SupplierID char(8),
ClothesID char(8),
SupplyPrice int,
SupplyCount int,
primary key(ContractID)
);

create table SalesInformation(
ClothesID char(8),
StoreID char(8),
SalesCount int,
primary key(ClothesID,StoreID)
);

create table BrandInformation(
BrandID char(8),
BrandName nvarchar(20),
BrandDescription nvarchar(100),
primary key(BrandID)
);
