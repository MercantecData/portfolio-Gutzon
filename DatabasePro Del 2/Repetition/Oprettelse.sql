CREATE DATABASE gamestore;

USE gamestore;

CREATE TABLE store_location (
	id INT PRIMARY KEY AUTO_INCREMENT,
	name TEXT
);

CREATE TABLE items (
	id INT PRIMARY KEY AUTO_INCREMENT,
	name TEXT,
	publishing_year INT
);

CREATE TABLE physical_items (
	id INT PRIMARY KEY AUTO_INCREMENT,
	itemID INT,
	locationID INT,
	FOREIGN KEY (itemID) REFERENCES items(id),
	FOREIGN KEY (locationID) REFERENCES store_location(id)
);

INSERT INTO items(name, publishing_year) VALUES
('Red Dead Redemption 2', 2018),
('Marvels Spiderman', 2018),
('Portal', 2007);

INSERT INTO store_location(name) VALUES
('Aalborg'),
('Viborg'),
('København');


-- querie til at insætte data i physical_items

INSERT INTO physical_items(itemID, locationID) VALUES
(1, 1),
(1, 2),
(1, 3),
(2, 2),
(2, 3),
(3, 1);



-- Ændringer og tilføjelser

ALTER TABLE physical_items
ADD COLUMNS stock INT;

UPDATE physical_items
SET 
	stock = 100,
[WHERE
	id = 1];

UPDATE physical_items
SET 
	stock = 150,
[WHERE
	id = 2];
	
UPDATE physical_items
SET 
	stock = 50,
[WHERE
	id = 3];

UPDATE physical_items
SET 
	stock = 200,
[WHERE
	id = 4];

UPDATE physical_items
SET 
	stock = 20,
[WHERE
	id = 5];
	
UPDATE physical_items
SET 
	stock = 2,
[WHERE
	id = 6];


CREATE TABLE opening_hours