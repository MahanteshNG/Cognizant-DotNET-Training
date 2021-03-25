select * from menu_item;
ALTER TABLE menu_item DROP COLUMN CartItems_idCartItems;
ALTER TABLE menu_item MODIFY COLUMN deliveryfree BIT;
drop table menu_item;
drop schema truyum;
-- View Menu Item List Admin
-- 1 a.  Insertion 
insert into menu_item(menu_id,menu_name,menu_price,menu_active,menu_dol,menu_category,menu_free_delivery) values('8001','Sandwich','99.00',1,'2017-05-13','Main Course',1);
insert into menu_item(menu_id,menu_name,menu_price,menu_active,menu_dol,menu_category,menu_free_delivery) values('8002','Burger','129.00',1,'2017-12-23','Main Course',0);
insert into menu_item(menu_id,menu_name,menu_price,menu_active,menu_dol,menu_category,menu_free_delivery) values('8003','Pizza','149.00',1,'2017-08-21','Main Course',0);
insert into menu_item(menu_id,menu_name,menu_price,menu_active,menu_dol,menu_category,menu_free_delivery) values('8004','French Fries','57.00',0,'2017-07-02','Starters',1);
insert into menu_item(menu_id,menu_name,menu_price,menu_active,menu_dol,menu_category,menu_free_delivery) values('8005','Chocolate Brownie','32.00',1,'2022-11-02','Dessert',1);
insert into menu_item(menu_id,menu_name,menu_price,menu_active,menu_dol,menu_category,menu_free_delivery) values('8006','Chocolate Cake','32.58',1,'2020-06-25','Sweet',1);

-- 1 b. get all items
select * from menu_item;
-- 2   example date of launch
select * from menu_item where menu_dol >= '2017-03-15' and menu_active = 1;
-- 3  a. 
select * from menu_item where menu_id = '8003';
-- 3 b.
update menu_item 
set menu_id='8010',menu_name='Steak',menu_price='45.68',menu_active=1,menu_dol='2020-07-22',menu_category='Main Course',menu_delivery_free= 1
where menu_id = '8001';
-- 4 a 
insert into users(user_id,user_name) values(100,'Muna Parida');
insert into users(user_id,user_name) values(101,'Suraj Parida');
select * from users;
select * from cart;
truncate cart;
insert into cart(cart_id,cart_us_id,cart_pr_id) values(10,100,8002);
insert into cart(cart_id,cart_us_id,cart_pr_id) values(11,100,8003);
insert into cart(cart_id,cart_us_id,cart_pr_id) values(12,100,8004);
-- 5 a
select * from menu_item join cart on menu_item.menu_id = cart.cart_pr_id join user on cart.cart_us_id=user.user_id
where user.user_id = '100';
-- 5 b 
select sum(menu_price) from menu_item join cart on menu_item.menu_id = cart.cart_pr_id join user on cart.cart_us_id=user.user_id
where user.user_id = '100';
-- 6 
Delete from cart where cart_us_id ='100' and cart_pr_id ='8003';