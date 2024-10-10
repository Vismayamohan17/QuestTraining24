CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	email VARCHAR(30) NOT NULL UNIQUE,
	phone VARCHAR(15) NOT NULL UNIQUE,
	address VARCHAR(50)
)
CREATE TABLE accounts
(
	id INT PRIMARY KEY IDENTITY,
	acc_number VARCHAR(20) NOT NULL UNIQUE,
	acc_type VARCHAR(30) NOT NULL,
	balance DECIMAL(15,2) NOT NULL CHECK(balance >= 0),
	created_at DATETIME2 DEFAULT GETDATE(),
	customer_id INT NOT NULL,
	
	CONSTRAINT FK_accounts_cust_id FOREIGN KEY(customer_id)
	REFERENCES customers(id)
)
CREATE TABLE transactions
(
	id INT PRIMARY KEY IDENTITY,
	sender_id INT NOT NULL,
	transaction_type VARCHAR(20) NOT NULL CHECK(transaction_type IN('Deposit','Withdrawal','Transfer')),
	amount DECIMAL(15,2) NOT NULL CHECK(amount > 0),
	transaction_date DATETIME2 DEFAULT GETDATE(),
	receiver_id INT NULL,
	
	CONSTRAINT FK_transactions_account FOREIGN KEY(sender_id)
	REFERENCES accounts(id),
	CONSTRAINT FK_transactions_receiver FOREIGN KEY(receiver_id)
	REFERENCES accounts(id)
)

INSERT INTO customers (name, email, phone, address)
VALUES
('John Doe', 'john.doe@example.com', '123-456-7890', '123 Elm St'),
('Jane Smith', 'jane.smith@example.com', '098-765-4321', '456 Oak St'),
('Michael Brown', 'michael.brown@example.com', '555-123-4567', '789 Pine St'),
('Emily Davis', 'emily.davis@example.com', '222-333-4444', '321 Maple St'),
('David Wilson', 'david.wilson@example.com', '111-222-3333', '654 Cedar St');


INSERT INTO accounts (acc_number, acc_type, balance, created_at, customer_id)
VALUES
('ACC1234567890', 'Savings', 1500.00, GETDATE(), 1),
('ACC9876543210', 'Checking', 2500.50, GETDATE(), 2),
('ACC4567891234', 'Savings', 3200.75, GETDATE(), 3),
('ACC3214569870', 'Checking', 5000.00, GETDATE(), 4),
('ACC6549873210', 'Savings', 780.20, GETDATE(), 5);

INSERT INTO transactions (sender_id, transaction_type, amount, transaction_date, receiver_id)
VALUES
(1, 'Deposit', 1000.00, GETDATE(), NULL),
(2, 'Withdrawal', 500.00, GETDATE(), NULL),
(3, 'Transfer', 300.00, GETDATE(), 4),
(4, 'Transfer', 1500.00, GETDATE(), 5),
(5, 'Deposit', 2000.00, GETDATE(), NULL);


select * from customers;
select * from transactions;

--Update amount
UPDATE accounts
SET balance = balance + 500
WHERE id = 1;

UPDATE accounts
SET balance = balance - 1500
WHERE id = 2;

UPDATE accounts
SET balance = balance - 1000
WHERE id = 3;

UPDATE accounts
SET balance = balance + 2500
WHERE id = 4;

UPDATE accounts
SET balance = balance + 2000
WHERE id = 5;

--Withdraw an amount
INSERT INTO transactions(sender_id,transaction_type,amount)
VALUES (1,'Withdrawal',500.00);

--Deposit into account 3
INSERT INTO transactions(sender_id,transaction_type,amount)
VALUES(3,'Deposit',1000.00);

--Transfer from account 3 to account 5
INSERT INTO transactions(sender_id,transaction_type,amount,receiver_id)
VALUES(3,'Transfer',200.00,5);

--Using join
SELECT transactions.transaction_type,transactions.amount,accounts.acc_number,accounts.acc_type,customers.name
FROM customers INNER JOIN accounts ON customers.id = accounts.id INNER JOIN transactions ON accounts.id = 1;