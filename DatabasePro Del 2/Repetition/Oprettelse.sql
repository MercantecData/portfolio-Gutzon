CREATE DATABASE gamestore; USE
    gamestore;
CREATE TABLE store_location(
    id INT PRIMARY KEY AUTO_INCREMENT,
    NAME TEXT
); CREATE TABLE items(
    id INT PRIMARY KEY AUTO_INCREMENT,
    NAME TEXT,
    publishing_year INT
); CREATE TABLE physical_items(
    id INT PRIMARY KEY AUTO_INCREMENT,
    itemID INT,
    locationID INT,
    FOREIGN KEY(itemID) REFERENCES items(id),
    FOREIGN KEY(locationID) REFERENCES store_location(id)
); INSERT INTO items(NAME, publishing_year)
VALUES('Red Dead Redemption 2', 2018),('Marvels Spiderman', 2018),('Portal', 2007);
INSERT INTO store_location(NAME)
VALUES('Aalborg'),('Viborg'),('København');
-- querie til at insætte data i physical_items
INSERT INTO physical_items(itemID, locationID)
VALUES(1, 1),(1, 2),(1, 3),(2, 2),(2, 3),(3, 1);
-- Ændringer og tilføjelser
ALTER TABLE
    physical_items ADD COLUMN stock INT;
UPDATE
    physical_items
SET
    stock = 100
WHERE
    id = 1;
UPDATE
    physical_items
SET
    stock = 150
WHERE
    id = 2;
UPDATE
    physical_items
SET
    stock = 50
WHERE
    id = 3;
UPDATE
    physical_items
SET
    stock = 200
WHERE
    id = 4;
UPDATE
    physical_items
SET
    stock = 20
WHERE
    id = 5;
UPDATE
    physical_items
SET
    stock = 2
WHERE
    id = 6;
CREATE TABLE opening_hours(
    id INT PRIMARY KEY AUTO_INCREMENT,
    locationID INT NOT NULL,
    DAY DATE NOT NULL,
    opening_time TIME,
    closing_time TIME,
    FOREIGN KEY(locationID) REFERENCES store_location(id)
); INSERT INTO opening_hours(
    locationID,
    DAY,
    opening_time,
    closing_time
)
VALUES(
    1,
    '2019-12-17',
    '10:00',
    '18:30'
),(
    2,
    '2019-12-17',
    '9:45',
    '17:00'
),(
    3,
    '2019-12-17',
    '6:00',
    '22:20'
),(
    1,
    '2019-12-20',
    '10:00',
    '18:30'
),(
    2,
    '2019-12-20',
    '10:00',
    '18:30'
),(
    3,
    '2019-12-21',
    '10:00',
    '18:30'
),(
    2,
    '2019-12-22',
    '10:00',
    '18:30'
),(
    1,
    '2019-12-25',
    '10:00',
    '18:30'
);