create database school
use school
create table student(student_id int primary key,student_name varchar(25),student_class int check(student_class<=12))
create table subjects(subjects_id int primary key,subjects_name varchar(25))
create table class(class_roomno int primary key,class_strength int)

create index student_index on student(student_id,student_name,student_class)
create index subjects_index on subjects(subjects_id,subjects_name)
create index class_index on class(class_roomno,class_strength)

insert into student values(1,'Aditi',12)
insert into student values(2,'Ajay',11)
insert into student values(3,'Shefali',8)
insert into student values(4,'Sawaraj',12)
insert into student values(5,'Riya',10)
select * from student

insert into subjects values(101,'EVS')
insert into subjects values(301,'English')
insert into subjects values(445,'Maths')
insert into subjects values(166,'Science')
insert into subjects values(243,'Hindi')
select * from subjects

insert into class values(01,45)
insert into class values(02,20)
insert into class values(03,34)
insert into class values(04,44)
insert into class values(05,50)
select * from class

select*from student
select*from subjects
select*from class