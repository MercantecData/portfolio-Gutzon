CREATE DATABASE triggers;

USE triggers;

CREATE TABLE persons(
	id INT PRIMARY KEY AUTO_INCREMENT,
	name TEXT,
	modified DATETIME ON UPDATE NOW() /* CURTIME() kan ikke bruges. Man kan bruge NOW() eller CURRENT_TIMESTAMP */
);

CREATE TABLE cars(
	id INT PRIMARY KEY AUTO_INCREMENT,
	owner_id INT,
	FOREIGN KEY (owner_id)
	REFERENCES persons(id) ON DELETE SET NULL
);

CREATE TABLE foo(
	id INT PRIMARY KEY AUTO_INCREMENT,
	name TEXT,
	modified DATETIME ON UPDATE CURRENT_TIMESTAMP
);

INSERT INTO foo (name) VALUES ('John');
UPDATE foo SET name = 'Igor';
SELECT * FROM foo;

INSERT INTO persons (name) VALUES ('Jack');
INSERT INTO cars (owner_id) VALUES (1);

CREATE TRIGGER new_car AFTER INSERT ON persons
FOR EACH ROW INSERT INTO cars (owner_id) VALUES (NEW.id);

INSERT INTO persons (name) VALUES ('Jack'),('Jill'),('Paul');
SELECT * FROM cars;

/* Trigger Syntax

CREATE TRIGGER <navn på trigger> <BEFORE | AFTER>
<INSERT | DELETE | UPDATE> ON <table_navn>
FOR EACH ROW <query>;
*/
--Udfordring 1
DELIMITER //
CREATE PROCEDURE add_name_to_foo(IN name TEXT)
BEGIN
	INSERT INTO foo (name) VALUES (name);
END //
DELIMITER ;
	
CREATE TRIGGER add_to_foo AFTER INSERT ON persons
FOR EACH ROW call add_name_to_foo(NEW.name);

--Udfordring 2
DELIMITER //
CREATE TRIGGER delete_person BEFORE DELETE ON cars
FOR EACH ROW
BEGIN
DELETE FROM foo WHERE foo.name = (SELECT name FROM persons WHERE persons.id = OLD.owner_id);
DELETE FROM persons WHERE persons.id = OLD.owner_id;
END //
-- Det har ingen formål det jeg gøre ved foo men det var bare for at have noget at sætte den til

--Udfordring 3
DELIMITER //
CREATE TRIGGER delete_cars BEFORE DELETE ON persons
FOR EACH ROW
BEGIN
DELETE FROM cars WHERE cars.owner_id = OLD.id;
END //
/* Jeg har tre triggers på person.
add_to_foo: Den køre efter man tilføjer til person.
new_car: 	Den køre også efter man tilføjer til person.
delete_cars_that_are_null: Den køre før man sletter en række i persons
*/
	