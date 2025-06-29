create database Grifindo_Toys_Management;


use Grifindo_Toys_Management;


CREATE TABLE employee (
    emp_id VARCHAR(10) PRIMARY KEY,
    emp_name VARCHAR(255) NOT NULL,
    tel_num VARCHAR(20) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    joined_date DATE NOT NULL,
	salary DECIMAL(10,2) NOT NULL,
    ot_rate DECIMAL(10,2) NOT NULL,
    allowance DECIMAL(10,2) NOT NULL,
);

CREATE TABLE salary (
    salary_id INT PRIMARY KEY IDENTITY,
    emp_id VARCHAR(10),
    salary_month VARCHAR(15) DEFAULT 'Jan',
    nopay DECIMAL(10,2) DEFAULT 0,
    basepay DECIMAL(10,2) DEFAULT 0,
    grosspay DECIMAL(10,2) DEFAULT 0,
    FOREIGN KEY (emp_id) REFERENCES employee(emp_id)
	ON UPDATE CASCADE
    ON DELETE CASCADE
);

CREATE TABLE settings (
    setting_id INT PRIMARY KEY IDENTITY,
    salary_cycle_start_date DATE NOT NULL,
    salary_cycle_end_date DATE NOT NULL,
    salary_cycle_days INT NOT NULL,
    num_of_leaves INT NOT NULL,
    govt_tax float NOT NULL
);

INSERT INTO employee (emp_id, emp_name, tel_num, gender, joined_date, salary, ot_rate, allowance)
VALUES 
    ('E003', 'John Smith', '0123456789', 'm', '2020-01-01', 50000.00, 500.00, 10000.00),
    ('E004', 'Jane Doe', '0234567890', 'f', '2021-02-01', 60000.00, 1000.00, 20000.00),
    ('E005', 'Tom Lee', '0345678901', 'm', '2019-03-01', 70000.00, 1500.00, 30000.00),
    ('E006', 'Alice Chen', '0456789012', 'f', '2022-04-01', 80000.00, 2000.00, 40000.00),
    ('E007', 'Mike Wang', '0567890123', 'm', '2021-05-01', 90000.00, 2500.00, 50000.00);

INSERT INTO employee (emp_id, emp_name, tel_num, gender, joined_date, salary, ot_rate, allowance)
VALUES 
    ('E008', 'Emily Wang', '0678901234', 'f', '2020-06-01', 55000.00, 600.00, 15000.00),
    ('E009', 'Kevin Chen', '0789012345', 'm', '2021-07-01', 65000.00, 1200.00, 25000.00),
    ('E010', 'Grace Liu', '0890123456', 'f', '2019-08-01', 75000.00, 1800.00, 35000.00),
    ('E011', 'Henry Wu', '0901234567', 'm', '2022-09-01', 85000.00, 2200.00, 45000.00),
    ('E012', 'Sophie Zhang', '0012345678', 'f', '2021-10-01', 95000.00, 2400.00, 55000.00);


INSERT INTO login (username, password) VALUES
('admin', '1234');


INSERT INTO salary (emp_id, salary_month, nopay, basepay, grosspay)
VALUES 
('E002', 'Jan', 20000.00, 30000.00, 50000.00),
('E009', 'Jan', 15000.00, 35000.00, 50000.00),
('E005', 'Jan', 10000.00, 40000.00, 50000.00),
('E011', 'Jan', 12000.00, 38000.00, 50000.00),
('E007', 'Jan', 18000.00, 32000.00, 50000.00);
