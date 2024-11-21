-- E-commerce Platform Schema
create database aa;
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Email VARCHAR(100),
    RegistrationDate DATE
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(200),
    Price DECIMAL(10, 2),
    CategoryID INT
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Questions

-- 1. List all products with their category names, including products without a category.
select * from products left join categories on categories.categoryid=products.categoryid;

-- 2. Display all customers and their order history, including customers who haven't placed any orders.
select * from customers left join orders on customers.customerid=orders.customerid ;

-- 3. Show all categories and the products in each category, including categories without any products.
select * from categories left join products on categories.categoryid=products.categoryid order by categories.categoryid;

-- 4. List all possible customer-product combinations, regardless of whether a purchase has occurred.
select * from customers cross join products;

-- 5. Display all orders with customer and product information, including orders where either the customer or product information is missing.
select * from orders left join customers on orders.customerid=customers.customerid left join orderdetails on orderdetails.orderid=orders.orderid left join products on products.productid=orderdetails.productid; 

-- 6. Show all products that have never been ordered, along with their category information.
select * from products left join orderdetails on products.productid=orderdetails.productid left join categories on categories.categoryid=products.categoryid where orderdetails.orderdetailid is null; 

-- 7. List all customers who have placed orders in the last week, along with the products they've purchased.
select * from customers left join orders on customers.customerid=orders.customerid left join orderdetails on orderdetails.orderid=orders.orderid left join products on products.productid=orderdetails.productid where datediff(day,orders.orderdate,getdate())<=7;

-- 8. Display all categories with products priced over $100, including categories without such products.
select * from categories left join products on categories.categoryid=products.categoryid;

-- 9. Show all orders placed before 2023 and any associated product information.
select * from orders left join orderdetails on orders.orderid=orderdetails.orderid left join products on products.productid=orderdetails.productid where year(orderdate)=2023;

-- 10. List all possible category-customer combinations, regardless of whether the customer has purchased a product from that category.
select * from categories cross join customers;

