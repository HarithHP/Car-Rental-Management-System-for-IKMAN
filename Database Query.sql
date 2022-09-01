create database ikman_app;
use ikman_app;
create table car_details (carreg_no varchar(10) primary key,cartype varchar(10),Brand varchar(20),model varchar(20),
price decimal(8,2),Colour varchar(15),Available varchar(5));

insert into car_details values 
('C1', 'Sedan', 'Toyota', 'Allion', 3500.00,'White','Yes');
insert into car_details values 
('C2', 'Hatchback', 'Audi', 'A3', 4000.50,'Black','Yes');


select * from car_details;
