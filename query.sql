
-- create
CREATE TABLE Сategories (
	Id INT not null PRIMARY KEY,
	categoryName varchar(256) not null
);

CREATE TABLE Products (
	Id INT not null PRIMARY KEY,
	productName varchar(256) not null,
	productCategoryID int foreign KEY references Сategories(Id)
);

-- insert
INSERT INTO Сategories(Id, categoryName) VALUES (0, 'Категория1');
INSERT INTO Сategories(Id, categoryName) VALUES (1, 'Категория2');
INSERT INTO Сategories(Id, categoryName) VALUES (2, 'Категория3');

INSERT INTO Products(Id, productName, productCategoryID) VALUES (0, 'Продукт1', 0);
INSERT INTO Products(Id, productName, productCategoryID) VALUES (1, 'Продукт2', 1);
INSERT INTO Products(Id, productName, productCategoryID) VALUES (2, 'Продукт3', 2);
INSERT INTO Products(Id, productName, productCategoryID) VALUES (3, 'Продукт4', 1);
INSERT INTO Products(Id, productName, productCategoryID) VALUES (4, 'Продукт5', 1);
INSERT INTO Products(Id, productName, productCategoryID) VALUES (5, 'Продукт6', null);

select productName as 'Имя продукта', categoryName as 'Имя категории' from Products left join Сategories on productCategoryID = Сategories.Id