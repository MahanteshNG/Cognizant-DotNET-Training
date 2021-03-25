create  database truYum
go
use truYum
go
create table menu_Items(
	item_id int not null primary key,
	item_name varchar(max),
	item_price decimal(10,2),
	item_availability varchar(3),
	item_launch_date date,
	item_category varchar(max),
	item_delivery varchar(3),
)	
go
create table truYumUser(
	user_Id int not null primary key,
	user_name varchar(max),
)
go
create table cart_Item(
	cart_id int not null primary key,
	users_id int,
	item_id int,
	constraint fk_menuitem_table foreign key (item_id) references menu_Items(item_id),
	constraint fk_user_table foreign key (users_id) references truYumUser(user_Id)
)