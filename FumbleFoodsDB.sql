

create table Address(
addressId int not null auto_increment,
shippingAddress boolean not null Default 'True',
city varchar(255) not null,
state varchar(255) not null,
zipcode varchar(255) not null,
street varchar(255) not null,
aptNum varchar(255),
primary key(addressId)
);

create table User(
userId int not null auto_increment,
firstName varchar(255) not null,
lastName varchar(255) not null,
password varchar(255) not null,
username varchar(255) not null,
creditCardNum varchar(255) not null,
addressId int not null,
foreign key(addressId) references Address (addressId),
primary key(userId)
);

create table Email (
emailId int not null auto_increment,
emailAddress varchar(255),
userId int not null,
foreign key (userId) references User (userId),
primary key (emailId)
);

create table Sale(
saleId int not null auto_increment,
billingAddress int not null,
userId int not null,
shippingAddress int not null,
foreign key(billingAddress) references Address (addressId),
foreign key(userId) references User(userId),
foreign key(shippingAddress) references Address (addressId),
primary key(saleId)
);

create table Manufacturer(
manufacturerId int not null auto_increment,
addressId int not null,
manufacturerName varchar(255) not null,
aboutSeller varchar(255) not null,
foreign key(addressId) references Address (addressId),
primary key(manufacturerId)
);

create table Product(
productId int not null auto_increment,
manfacturerId int not null,
productName varchar(255) not null,
description varchar(255) not null,
dimensions varchar(255) not null,
weight varchar(255) not null,
rating varchar(255) not null,
SKU varchar(255) not null,
inventory varchar(255) not null,
cost double not null,
category varchar(255) not null,
foreign key(manufacturerId) references Manufacturer(manufacturerId),
primary key (productId)
);

create table Purchase(
purchaseId int not null auto_increment,
productId int not null,
cost double not null,
saleId int not null,
foreign key (productId) references Product (productId),
foreign key(saleId) references Sale (saleId),
primary key(purchaseId)
);

create table ShoppingSale(
shoppingSaleId int not null auto_increment,
productId int not null,
startDate varchar(255) not null,
endDate varchar(255) not null,
category varchar(255),
percentage double,
dollarAmount double,
foreign key (productId) references Product(productId),
primary key (shoppingSaleId)
);

create table Cart(
cartPK int not null auto_increment,
userId int not null, 
productId int not null,
quantity int not null,
foreign key(userId) references User(userId),
foreign key(productId) references Product(productId),
primary key(cartPK)
);



#Insert into Address
 insert into Add
#Insert into Manufacturer

insert into Product(manufacturerId

