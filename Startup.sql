-- USE mysqlburgershack;
-- CREATE TABLE burgers(
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,
--   description VARCHAR(255),
--   PRIMARY KEY (id)
-- );
-- THIS IS A DUMB COMMENT TO REMIND YOU THAT YOU CANT USE INLINE COMMENTS
--  NOTE Add to table
ALTER TABLE burgers ADD price DECIMAL DEFAULT 1 AFTER description