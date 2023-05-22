/*USE master
DROP DATABASE BD_SalesCar*/
--CREATE DATABASE BD_SalesCar
USE BD_SalesCar

CREATE TABLE cars
(
	car_id int IDENTITY(1,1) NOT NULL,--id машины
	car_mark nvarchar(50),--марка машины
	car_model nvarchar(50),--модель машины
	body_type nvarchar(50),--кузов машины
	transmission nvarchar(50),--коробка передач машины
	car_power DECIMAL(10,2),--мощность машины
	engine_type nvarchar(50),--тип топлива машины
	release_year INT,--год выпуска машины
	qty_of_cars INT,
	PRIMARY KEY(car_id)
)
CREATE TABLE sales
(
	sale_id int IDENTITY(1,1) NOT NULL,--id продажи
	car_id INT NOT NULL,--id машины, которую продаём
	fio nvarchar(100),--фио покупателя
	phone nvarchar(12),--номер телефона покупателя
	sale_date date,--дата продажи
	price DECIMAL(10,2),--сумма продажи
	FOREIGN KEY (car_id) REFERENCES cars(car_id),
	PRIMARY KEY(sale_id)
)

INSERT INTO cars(car_mark,car_model,body_type,transmission,car_power,engine_type,release_year,qty_of_cars) VALUES
('BMW','X5 30Dd','Внедорожник','Автомат',265,'Дизель',2019,2),
('Mercedes-Benz','W201','Седан','Механика',122,'Бензин',1990,2),
('Hyundai','Solaris I','Хэтчбек','Автомат',123,'Бензин',2014,5)

INSERT INTO sales(car_id,fio,phone,sale_date,price) VALUES
(1,'Мидили Никита Олегович','+79118192815','30-11-2022',6500000),
(2,'Халле Александр','+79991563212','30-12-2022',350000),
(3,'Бажин Кирилл','+79831567878','30-04-2023',550000),
(3,'Коршикова Эльвина','+79113215648','30-01-2023',600000)


CREATE TABLE users
(
	usr_id int IDENTITY(1,1) NOT NULL,--id пользователя
	usr_name nvarchar(50),--имя пользователя
	pass nvarchar(50),--пароль пользователя
	usr_category nvarchar(50),--категория пользователя
	PRIMARY KEY(usr_id)
)

INSERT INTO users(usr_name,pass,usr_category) VALUES
('yozhikes','1488','admin'),
('user1','123123','user'),
('asdasd','123456','user')