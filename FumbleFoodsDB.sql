

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
image varchar(255) not null,
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



-- Inserting into Address table
INSERT INTO Address (shippingAddress, city, state, zipcode, street, aptNum)
VALUES 
(true, 'New York', 'NY', '10001', '123 Main St', 'Apt 1'),
(true, 'Los Angeles', 'CA', '90001', '456 Elm St', NULL),
(false, 'Chicago', 'IL', '60601', '789 Oak St', 'Apt 2');

-- Inserting into User table
INSERT INTO User (firstName, lastName, password, username, creditCardNum, addressId)
VALUES
('John', 'Doe', 'password123', 'johndoe', '1234567890123456', 1),
('Jane', 'Smith', 'letmein', 'janesmith', '9876543210987654', 2),
('Alice', 'Johnson', 'securepass', 'alicej', '1111222233334444', 3);

-- Inserting into Email table
INSERT INTO Email (emailAddress, userId)
VALUES
('john.doe@example.com', 1),
('jane.smith@example.com', 2),
('alice.johnson@example.com', 3);

-- Inserting into Sale table
##INSERT INTO Sale (billingAddress, userId, shippingAddress)
##VALUES


-- Inserting into Manufacturer table
INSERT INTO Manufacturer (addressId, manufacturerName, aboutSeller)
VALUES
(1, 'Farmers Fresh', 'We produce freshness.'),
(2, 'Whole Foods Farm.', 'Your trusted source for good whole food.'),
(3, 'GetCo', 'Pantry products and more.');

-- Inserting into Product table
INSERT INTO Product (manfacturerId, productName, description, dimensions, weight, rating, SKU, inventory, cost, image, category)
VALUES
(1, 'Bag of Apples', 'A bag of fresh fiji apple.', '2x2x2', '1 lb', '4.5', '1JHN234G', '1000', 2.99, 'apples.jpg', 'Fruit'),
(2, 'Rib Eye', 'Piece of Rib Eye Steak', '4x4x4', '3 lb', '4.8', 'GUIYFU431', '1234', 19.99, 'ribeye.jpg', 'Meat'),
(3, 'Organic Brown Eggs', 'A dozen of farm-fresh organic brown eggs.', '6x6x3', '1.5 lb', '4.7', 'EGG9876', '500', 4.99, 'eggs.jpg', 'Dairy'),
(1, 'Whole Wheat Bread', 'A loaf of freshly baked whole wheat bread.', '8x4x4', '1.2 lb', '4.6', 'BRD345', '300', 3.49, 'bread.jpg', 'Bakery'),
(1, 'Salmon Fillet', 'Fresh salmon fillet, rich in omega-3 fatty acids.', '10x6x2', '0.8 lb', '4.9', 'FISH123', '200', 12.99, 'salmon.jpg', 'Seafood'),
(1, 'Greek Yogurt', 'Creamy Greek yogurt with live probiotics.', '4x4x4', '2 lb', '4.8', 'YOG567', '400', 3.99, 'yogurt.jpg', 'Dairy'),
(3, 'Spinach', 'Fresh organic spinach leaves, perfect for salads.', '8x8x4', '0.5 lb', '4.6', 'SPN123', '200', 1.99, 'spinach.jpg', 'Vegetables'),
(3, 'Chicken Breast', 'Boneless, skinless chicken breast.', '6x4x2', '1.2 lb', '4.7', 'CHKN789', '300', 6.99, 'chicken.jpg', 'Meat'),
(3, 'Quinoa', 'Nutrient-rich quinoa grains.', '6x4x2', '1 lb', '4.5', 'QUN234', '500', 5.99, 'quinoa.jpg', 'Grains'),
(3, 'Green Tea', 'Organic green tea leaves for a refreshing brew.', '4x4x6', '0.3 lb', '4.8', 'TEA567', '1000', 4.49, 'tea.jpg', 'Beverages'),
(3, 'Avocado', 'Creamy Hass avocado, ripe and ready to eat.', '4x4x4', '0.5 lb', '4.7', 'AVO345', '300', 2.49, 'avocado.jpg', 'Produce'),
(3, 'Pasta Sauce', 'Classic tomato pasta sauce with Italian herbs.', '6x4x4', '1 lb', '4.6', 'SCE123', '400', 3.49, 'sauce.jpg', 'Pantry'),
(3, 'Almonds', 'Whole almonds, rich in protein and healthy fats.', '6x6x3', '1 lb', '4.8', 'ALM789', '500', 7.99, 'almonds.jpg', 'Snacks'),
(3, 'Honey', 'Pure, natural honey sourced from local beekeepers.', '4x4x4', '1 lb', '4.9', 'HNY456', '300', 8.99, 'honey.jpg', 'Pantry'),
(1, 'Broccoli', 'Fresh broccoli florets, packed with vitamins.', '6x6x6', '0.7 lb', '4.6', 'BRC567', '200', 1.99, 'broccoli.jpg', 'Produce'),
(2, 'Orange Juice', 'Freshly squeezed orange juice, no added sugar.', '4x4x8', '2 lb', '4.7', 'OJU789', '400', 5.49, 'orangejuice.jpg', 'Beverages'),
(2, 'Cheddar Cheese', 'Sharp cheddar cheese, perfect for sandwiches.', '6x6x3', '0.8 lb', '4.7', 'CHE123', '300', 6.49, 'cheddar.jpg', 'Dairy'),
(3, 'Chocolate Chip Cookies', 'Homemade chocolate chip cookies, soft and chewy.', '8x8x2', '0.5 lb', '4.8', 'CKI456', '200', 4.99, 'cookies.jpg', 'Snacks'),
(2, 'Pineapple', 'Sweet and juicy pineapple chunks, ready to eat.', '8x8x4', '2 lb', '4.6', 'PIN234', '300', 3.99, 'pineapple.jpg', 'Fruit'),
(2, 'Canned Tuna', 'Wild-caught tuna packed in water.', '6x6x3', '0.5 lb', '4.5', 'TUN789', '400', 2.99, 'tuna.jpg', 'Canned Goods');


##-- Inserting into Purchase table
##INSERT INTO Purchase (productId, cost, saleId)



-- Inserting into ShoppingSale table
##INSERT INTO ShoppingSale (productId, startDate, endDate, category, percentage, dollarAmount)



-- Inserting into Cart table
##INSERT INTO Cart (userId, productId, quantity)





