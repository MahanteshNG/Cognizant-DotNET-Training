CREATE TABLE users (
  user_id INT NOT NULL ,
  user_name VARCHAR(60) NOT NULL,
  PRIMARY KEY (user_id));

CREATE TABLE menu_item (
  menu_id INT NOT NULL ,
  menu_name VARCHAR(100) NULL,
  menu_price DECIMAL(8,2) NULL,
  menu_active BIT NULL,
  menu_dol DATE NULL,
  menu_category VARCHAR(45) NULL,
  menu_free_delivery BIT NULL,
  PRIMARY KEY (menu_id));

CREATE TABLE cart (
  cart_id INT NOT NULL ,
  cart_us_id INT NULL,
  cart_pr_id INT NULL,
  PRIMARY KEY (cart_id),
  INDEX cart_us_fk_idx (cart_us_id ASC),
  INDEX cart_pr_fk_idx (cart_pr_id ASC),
  CONSTRAINT cart_us_fk
    FOREIGN KEY (cart_us_id)
    REFERENCES users (user_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT cart_pr_fk
    FOREIGN KEY (cart_pr_id)
    REFERENCES menu_item (menu_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);