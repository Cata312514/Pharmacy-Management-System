create database pharmacy

create table users(
id int identity(1,1) primary key,
userRole varchar(50) not null,
names varchar(250) not null,
dob varchar(250) not null,
mobile bigint not null,
email varchar(250) not null,
username varchar(250) unique not null,
passwrd varchar(250) not null
)

select * from users


# userRole, names, dob, mobile, email, username, passwrd

create table MedicineList(
id int identity(1,1) primary key,
medNDC varchar(250) not null,
medName varchar(250) not null,
medDose varchar(250) not null,
medLOT varchar(250) not null,
mDate  varchar(250) not null,
eDate varchar(250) not null,
quantity bigint not null,
unitPrice bigint not null
);

select * from MedicineList

medNDC, medName, medDose, medLOT, mDate, eDate, quantity, unitPrice

select * from MedicineList where eDate >= getdate()

select medName from MedicineList where eDate >= getdate() and quantity > '0'
