CREATE TABLE Patients
(
	id INT PRIMARY KEY IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	gender VARCHAR(10) NOT NULL,
	age INT NOT NULL CHECK (age > 0 AND age < 120),
	phone_number VARCHAR(15) NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	created_at DATETIME NOT NULL DEFAULT GETDATE()
)

CREATE TABLE appointments
(
	id INT PRIMARY KEY IDENTITY,                           
    patient_id INT NOT NULL,                                
    appointment_date DATE NOT NULL CHECK (appointment_date >= CAST(GETDATE() AS DATE)),  
    appointment_time TIME NOT NULL,                            
    reason_for_visit VARCHAR(255) NOT NULL,                    
    doctor_name VARCHAR(100) NOT NULL,                        
    created_at DATETIME NOT NULL DEFAULT GETDATE(),   
    FOREIGN KEY (patient_id) REFERENCES patients(id)  
)

INSERT INTO patients (first_name, last_name, gender, age, phone_number, email)
VALUES
    ('John', 'Mathew', 'M', 30, '123-456-7890', 'john.mathew@example.com'),
    ('Anna', 'John', 'F', 25, '987-654-3210', 'anna.john@example.com'),
    ('Alex', 'Johnson', 'Other', 40, '555-555-5555', 'alex.johnson@example.com'),
    ('Rachel', 'Davis', 'F', 22, '444-444-4444', 'rachel.davis@example.com'),
    ('Merissa', 'Thomas', 'M', 35, '333-333-3333', 'merissa.thomas@example.com');


INSERT INTO appointments (patient_id, appointment_date, appointment_time, reason_for_visit, doctor_name)
VALUES
    (1, '2024-10-15', '09:00', 'Routine Checkup', 'Dr. James George'),
    (2, '2024-10-16', '10:30', 'Follow-up Visit', 'Dr. Alice John'),
    (3, '2024-10-17', '14:00', 'Annual Physical', 'Dr. Mathew Jose'),
    (4, '2024-10-18', '11:00', 'Consultation for Allergies', 'Dr. Denna Lee'),
    (5, '2024-10-19', '15:30', 'Dermatology Appointment', 'Dr. Emily Adams');