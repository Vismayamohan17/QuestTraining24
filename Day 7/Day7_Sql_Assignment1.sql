CREATE TABLE student(
  id INT PRIMARY KEY IDENTITY,
  name VARCHAR(30) NOT NULL
);

CREATE TABLE subjects(
  id INT PRIMARY KEY IDENTITY,
  sub_code VARCHAR(10) NOT NULL,
  subject VARCHAR(40) NOT NULL
);

CREATE TABLE exam(
  id INT PRIMARY KEY IDENTITY,
  exam_name VARCHAR(20),
  min_marks INT NOT NULL,
  max_marks INT NOT NULL
);

CREATE TABLE marks(
  id INT PRIMARY KEY IDENTITY,
  std_id INT,
  sub_id INT,
  exam INT,
  marks INT,
  
  CONSTRAINT fk_std_id FOREIGN KEY (std_id) REFERENCES student(id),
  CONSTRAINT fk_sub_id FOREIGN KEY (sub_id) REFERENCES subjects(id),
  CONSTRAINT fk_exam_id FOREIGN KEY (exam) REFERENCES exam(id)
);
INSERT INTO student VALUES
('Vismaya'),
('Athira'),
('Gopika'),
('Linu'),
('Merissa');

INSERT INTO subjects VALUES
('CST101','DBMS'),
('CST201','JAVA'),
('CST305','OS'),
('CST200','CD'),
('CST105','DS');

INSERT INTO exam VALUES
('S1',40,100),
('S2',50,100),
('S3',45,100),
('S4',35,100),
('S5',60,100);


INSERT INTO marks VALUES
(1, 1, 1, 75),  
(2, 2, 2, 80),  
(3, 3, 3, 60),  
(4, 4, 4, 50),  
(5, 5, 5, 90);  

SELECT student.id,subjects.subject,marks.marks,exam.exam_name
FROM
marks 
INNER JOIN
student ON marks.std_id = student.id
INNER JOIN
subjects ON marks.sub_id = subjects.id
INNER JOIN 
exam ON marks.exam = exam.id;
