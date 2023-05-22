/*USE master
DROP DATABASE BD_SalesCar*/
--CREATE DATABASE BD_SalesCar
USE BD_SalesCar

CREATE TABLE cars
(
	car_id int IDENTITY(1,1) NOT NULL,--id ������
	car_mark nvarchar(50),--����� ������
	car_model nvarchar(50),--������ ������
	body_type nvarchar(50),--����� ������
	transmission nvarchar(50),--������� ������� ������
	car_power DECIMAL(10,2),--�������� ������
	engine_type nvarchar(50),--��� ������� ������
	release_year INT,--��� ������� ������
	qty_of_cars INT,
	PRIMARY KEY(car_id)
)
CREATE TABLE sales
(
	sale_id int IDENTITY(1,1) NOT NULL,--id �������
	car_id INT NOT NULL,--id ������, ������� ������
	fio nvarchar(100),--��� ����������
	phone nvarchar(12),--����� �������� ����������
	sale_date date,--���� �������
	price DECIMAL(10,2),--����� �������
	FOREIGN KEY (car_id) REFERENCES cars(car_id),
	PRIMARY KEY(sale_id)
)

INSERT INTO cars(car_mark,car_model,body_type,transmission,car_power,engine_type,release_year,qty_of_cars) VALUES
('BMW','X5 30Dd','�����������','�������',265,'������',2019,2),
('Mercedes-Benz','W201','�����','��������',122,'������',1990,2),
('Hyundai','Solaris I','�������','�������',123,'������',2014,5)

INSERT INTO sales(car_id,fio,phone,sale_date,price) VALUES
(1,'������ ������ ��������','+79118192815','30-11-2022',6500000),
(2,'����� ���������','+79991563212','30-12-2022',350000),
(3,'����� ������','+79831567878','30-04-2023',550000),
(3,'��������� �������','+79113215648','30-01-2023',600000)


CREATE TABLE users
(
	usr_id int IDENTITY(1,1) NOT NULL,--id ������������
	usr_name nvarchar(50),--��� ������������
	pass nvarchar(50),--������ ������������
	usr_category nvarchar(50),--��������� ������������
	PRIMARY KEY(usr_id)
)

INSERT INTO users(usr_name,pass,usr_category) VALUES
('yozhikes','1488','admin'),
('user1','123123','user'),
('asdasd','123456','user')