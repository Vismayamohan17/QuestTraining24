CREATE TABLE course
(
	id INT PRIMARY KEY IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	Course VARCHAR(50) NOT NULL,
	fees int NOT NULL
)

INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Vismaya','Mohan','C Sharp',45000);
INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Merissa','Thomas','C Sharp',45000);
INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Aswathy','Krishnan','Embedded C',40000);
INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Devipriya','S','Embedded C',40000);
INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Athira','K H','Data Science',50000);
INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Gopika','S','Web Development',35000);
INSERT INTO course (first_name,last_name,Course,fees) VALUES
('Joel','Mathew','Embedded C',40000);



SELECT Course,count(id) as Number_of_students FROM course group by Course;

SELECT Course,SUM(fees) as Total_fees FROM course group by Course;

SELECT Top 1 Course,count(id) as  Max_number_of_enrollments FROM course group by Course order by count(id)desc;
