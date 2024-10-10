
CREATE TABLE customers
(
	acc_no BIGINT PRIMARY KEY,
	acc_name VARCHAR(30) NOT NULL,
	phn_no BIGINT UNIQUE NOT NULL,
	balance BIGINT CHECK(balance >= 0)
);

ALTER TABLE customers
ALTER COLUMN balance Decimal(10,3);

CREATE TABLE transactions
(
	id BIGINT PRIMARY KEY,
	sender_acc_no BIGINT,
	sender_name VARCHAR(30),
	receiver_acc_no BIGINT,
	receiver_name VARCHAR(30),
	transactions_type VARCHAR(20) NOT NULL,
	transactions_date DATE

	CONSTRAINT FK_sender_acc_no FOREIGN KEY(sender_acc_no)
	REFERENCES customers(acc_no),
	CONSTRAINT FK_receiver_acc_no FOREIGN KEY(receiver_acc_no)
	REFERENCES customers(acc_no)
);

INSERT INTO customers (acc_no, acc_name, phn_no, balance) VALUES
(100000001, 'John Doe', 9876543210, 50000),
(100000002, 'Jane Smith', 9123456789, 25000),
(100000003, 'Alice Johnson', 9988776655, 150000),
(100000004, 'Bob Brown', 9876512345, 0),
(100000005, 'Charlie Davis', 9112233445, 30000),
(100000006, 'Eve Wilson', 9876001234, 75000),
(100000007, 'Frank Taylor', 9876123456, 120000),
(100000008, 'Grace Hall', 9111001100, 45000),
(100000009, 'Hank Lee', 9876234567, 20000),
(100000010, 'Ivy White', 9113344556, 100000);

INSERT INTO transactions (id, sender_acc_no, sender_name, receiver_acc_no, receiver_name, transactions_type, transactions_date) VALUES
(1, 100000001, 'John Doe',NULL,'NULL', 'Withdraw', '2024-10-01'),
(2, 100000003, 'Alice Johnson', 100000004, 'Bob Brown', 'Transfer', '2024-10-02'),
(3, 100000005, 'Charlie Davis', NULL, 'NULL', 'Deposit', '2024-10-03'),
(4, 100000006, 'Eve Wilson', 100000005, 'Charlie Davis', 'Transfer', '2024-10-04'),
(5, 100000007, 'Frank Taylor', 100000008, 'Grace Hall', 'Transfer', '2024-10-05'),
(6, 100000009, 'Hank Lee',NULL, 'NULL', 'Withdraw', '2024-10-06'),
(7, 100000010, 'Ivy White', 100000009, 'Hank Lee', 'Transfer', '2024-10-07'),
(8, 100000002, 'Jane Smith', 100000001, 'John Doe', 'Transfer', '2024-10-08'),
(9, 100000004, 'Bob Brown', NULL, 'NULL', 'Deposit', '2024-10-09'),
(10, 100000008, 'Grace Hall', NULL, 'NULL', 'Deposit', '2024-10-10');








