CREATE TABLE suppliers
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(30) NOT NULL,
	contact_person VARCHAR(30) NOT NULL,
	phone_no BIGINT,
	email VARCHAR(20),
	address VARCHAR(40) NOT NULL
)

CREATE TABLE medications
(
	id INT PRIMARY KEY IDENTITY,
	med_name VARCHAR(50) NOT NULL,
	category VARCHAR(30) NOT NULL,
	price DECIMAL(5,2) NOT NULL,
	exp_date DATE,
	supplier_id INT UNIQUE,
	stock_quantity BIGINT

	CONSTRAINT FK_medication_sup_id FOREIGN KEY(supplier_id)
	REFERENCES suppliers(id)
)

CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(30) NOT NULL,
	phone_no BIGINT,
	email VARCHAR(20),
	address VARCHAR(40) NOT NULL
)

CREATE TABLE sales
(
	id INT PRIMARY KEY IDENTITY,
	cust_id INT,
	med_id INT,
	quantity BIGINT,
	sale_date DATE,
	total_price DECIMAL(10,2)

	CONSTRAINT FK_sales_cust_id FOREIGN KEY(cust_id)
	REFERENCES customers(id),
	CONSTRAINT FK_sales_med_id FOREIGN KEY(med_id)
	REFERENCES medications(id)
)

CREATE TABLE inventory
(
	id INT PRIMARY KEY IDENTITY,
	med_id INT,
	supplier_id INT,
	stock_in BIGINT,
	stock_out BIGINT,
	date_added DATE

	CONSTRAINT FK_inventory_med_id FOREIGN KEY(med_id)
	REFERENCES medications(id),
	CONSTRAINT FK_inventory_sup_id FOREIGN KEY(supplier_id)
	REFERENCES suppliers(id)
)
GO

CREATE PROCEDURE sp_suppliers
(
	@Name VARCHAR(30),
	@Contact_person VARCHAR(30),
	@Phone_no BIGINT,
	@Email VARCHAR(20),
	@Address VARCHAR(40)
)
AS
BEGIN
INSERT INTO suppliers(name,contact_person,phone_no,email,address)
VALUES(@Name,@Contact_person,@Phone_no,@Email,@Address);
END;

EXEC sp_suppliers
    @Name = 'Tech Solutions',
    @Contact_person = 'Alice Brown',
    @Phone_no = 1234567890,
    @Email = 'alice@techsolutions.com',
    @Address = '456 Innovation Way';

EXEC sp_suppliers
    @Name = 'Green Energy Co.',
    @Contact_person = 'Bob Green',
    @Phone_no = 9876543210,
    @Email = 'bob@greenenergy.com',
    @Address = '789 Solar Ave';

EXEC sp_suppliers
    @Name = 'Fresh Foods Inc.',
    @Contact_person = 'Charlie Miller',
    @Phone_no = 1029384756,
    @Email = 'charlie@freshfoods.com',
    @Address = '321 Market St';


EXEC sp_suppliers
    @Name = 'Smart Devices Ltd.',
    @Contact_person = 'David Lee',
    @Phone_no = 5647382910,
    @Email = 'david@smartdevices.com',
    @Address = '101 Tech Park';

EXEC sp_suppliers
    @Name = 'NextGen Motors',
    @Contact_person = 'Emma White',
    @Phone_no = 6574839201,
    @Email = 'emma@nextgenmotors.com',
    @Address = '555 Motor City Blvd';

GO
CREATE PROCEDURE sp_medications
(
	@Med_name VARCHAR(50),
	@Category VARCHAR(30),
	@Price DECIMAL(5,2),
	@Exp_date DATE,
	@Supplier_id INT,
	@Stock_quantity BIGINT
)
AS
BEGIN
INSERT INTO medications(med_name,category,price,exp_date,supplier_id,stock_quantity)
VALUES(@Med_name,@Category,@Price,@Exp_date,@Supplier_id,@Stock_quantity);
END;

EXEC sp_medications
    @Med_name = 'Amoxicillin 500mg',
    @Category = 'Antibiotic',
    @Price = 12.50,
    @Exp_date = '2025-06-30',
    @Supplier_id = 1,
    @Stock_quantity = 500;

EXEC sp_medications
    @Med_name = 'Paracetamol 650mg',
    @Category = 'Painkiller',
    @Price = 8.75,
    @Exp_date = '2024-12-15',
    @Supplier_id = 2,
    @Stock_quantity = 1000;

EXEC sp_medications
    @Med_name = 'Ciprofloxacin 250mg',
    @Category = 'Antibiotic',
    @Price = 15.25,
    @Exp_date = '2026-02-10',
    @Supplier_id = 3,
    @Stock_quantity = 300;

EXEC sp_medications
    @Med_name = 'Ibuprofen 400mg',
    @Category = 'Painkiller',
    @Price = 10.00,
    @Exp_date = '2025-08-05',
    @Supplier_id = 4,
    @Stock_quantity = 750;

EXEC sp_medications
    @Med_name = 'Lisinopril 10mg',
    @Category = 'Antihypertensive',
    @Price = 20.99,
    @Exp_date = '2027-01-20',
    @Supplier_id = 5,
    @Stock_quantity = 600;


GO
CREATE PROCEDURE sp_customers
(
	@Name VARCHAR(30),
	@Phone_no BIGINT,
	@Email VARCHAR(20),
	@Address VARCHAR(40)
)
AS
BEGIN
INSERT INTO customers(name,phone_no,email,address)
VALUES(@Name,@Phone_no,@Email,@Address);
END;

EXEC sp_customers
    @Name = 'John Doe',
    @Phone_no = 9876543210,
    @Email = 'john.doe@gmail.com',
    @Address = '123 Elm Street';

EXEC sp_customers
    @Name = 'Jane Smith',
    @Phone_no = 8765432109,
    @Email = 'jane.smith@yahoo.com',
    @Address = '456 Oak Avenue';

EXEC sp_customers
    @Name = 'Michael Brown',
    @Phone_no = 7654321098,
    @Email = 'michael.b@gmail.com',
    @Address = '789 Maple Road';

EXEC sp_customers
    @Name = 'Emily Davis',
    @Phone_no = 6543210987,
    @Email = 'emily.davis@outlook.com',
    @Address = '101 Pine Street';

EXEC sp_customers
    @Name = 'David Wilson',
    @Phone_no = 5432109876,
    @Email = 'david.wilson@gmail.com',
    @Address = '202 Cedar Lane';


GO
CREATE PROCEDURE sp_sales
(
	@Cust_id INT,
	@Med_id INT,
	@Quantity BIGINT,
	@Sale_date DATE,
	@Total_price DECIMAL(10,2)

)
AS
BEGIN
INSERT INTO sales(cust_id,med_id,quantity,sale_date,total_price)
VALUES(@Cust_id,@Med_id,@Quantity,@Sale_date,@Total_price);
END;

EXEC sp_sales
    @Cust_id = 1,
    @Med_id = 101,
    @Quantity = 2,
    @Sale_date = '2024-10-01',
    @Total_price = 25.50;

EXEC sp_sales
    @Cust_id = 2,
    @Med_id = 102,
    @Quantity = 5,
    @Sale_date = '2024-10-02',
    @Total_price = 75.00;

EXEC sp_sales
    @Cust_id = 3,
    @Med_id = 103,
    @Quantity = 1,
    @Sale_date = '2024-10-03',
    @Total_price = 15.25;

EXEC sp_sales
    @Cust_id = 4,
    @Med_id = 104,
    @Quantity = 10,
    @Sale_date = '2024-10-04',
    @Total_price = 100.00;

EXEC sp_sales
    @Cust_id = 5,
    @Med_id = 105,
    @Quantity = 3,
    @Sale_date = '2024-10-05',
    @Total_price = 45.75;


GO
CREATE PROCEDURE sp_inventory
(
	@Med_id INT,
	@Supplier_id INT,
	@Stock_in BIGINT,
	@Stock_out BIGINT,
	@Date_added DATE

)
AS
BEGIN
INSERT INTO inventory(med_id,supplier_id,stock_in,stock_out,date_added)
VALUES(@Med_id,@Supplier_id,@Stock_in,@Stock_out,@Date_added);
END;

EXEC sp_inventory
    @Med_id = 101,
    @Supplier_id = 1,
    @Stock_in = 150,
    @Stock_out = 0,
    @Date_added = '2024-10-01';

EXEC sp_inventory
    @Med_id = 102,
    @Supplier_id = 2,
    @Stock_in = 200,
    @Stock_out = 20,
    @Date_added = '2024-10-02';

EXEC sp_inventory
    @Med_id = 103,
    @Supplier_id = 3,
    @Stock_in = 300,
    @Stock_out = 50,
    @Date_added = '2024-10-03';

EXEC sp_inventory
    @Med_id = 104,
    @Supplier_id = 4,
    @Stock_in = 100,
    @Stock_out = 10,
    @Date_added = '2024-10-04';

EXEC sp_inventory
    @Med_id = 105,
    @Supplier_id = 5,
    @Stock_in = 250,
    @Stock_out = 100,
    @Date_added = '2024-10-05';


SELECT * FROM medications;