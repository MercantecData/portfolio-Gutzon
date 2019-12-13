USE
    employees;
CREATE VIEW old_employees AS SELECT
    first_name AS Fornavn,
    last_name AS Efternavn
FROM
    employees
WHERE
    YEAR(hire_date) < 1990
ORDER BY
    Fornavn,
    Efternavn;
DELIMITER
    //
CREATE PROCEDURE insert_dummy(IN empno INT)
BEGIN
    INSERT INTO employees(
        emp_no,
        birth_date,
        first_name,
        last_name,
        gender,
        hire_date
    )
VALUES(
    empno,
    '1970-01-01',
    'foo',
    'bar',
    'M',
    CURDATE()) ;
END //
DELIMITER ;
CALL
    insert_dummy(12345);
--	^^^^^^^^^^^^^^^^^^^ Den er ikke glad for det fordi emp_no 12345 existere i sample databasen
--	så man skulle nok endte have gjort sådan at den overskriver dataen på placeringen istedet
--	eller give et nummer der ikke er der endnu.
 
 --Udfordringer
 
 --1
 CREATE VIEW full_employment AS
 SELECT 
	employees.first_name AS Fornavn,
    employees.last_name AS Efternavn,
    titles.title AS Stilling,
    departments.dept_name,
    salaries.salary AS Løn
FROM
	employees
LEFT JOIN salaries ON salaries.emp_no = employees.emp_no
LEFT JOIN titles ON titles.emp_no = employees.emp_no
LEFT JOIN dept_emp ON dept_emp.emp_no = employees.emp_no
LEFT JOIN departments ON departments.dept_no = dept_emp.dept_no
ORDER BY
	Fornavn,
	Efternavn;
 
 --2
 /*Det view har ingen columm med fødselsdag data så man kan ikke sorter efter fødselsdag.
 
 Så jeg prøvede at joine employee med view old_employees
*/
SELECT
    old_employees.Fornavn,
    old_employees.Efternavn,
    employees.birth_date
FROM
    old_employees
LEFT JOIN employees ON old_employees.Fornavn = employees.first_name AND old_employees.Efternavn = employees.last_name
ORDER BY
    birth_date
-- Man bør have en unique column i et view hvis man skal bruge den sammen med andet eller tage en primary key med fra en af tabellerne.
/*
Men det fungerede helle ikke det fik databasen til bruge alt CPU men uden resultat
*/
--3
DELIMITER
    //
CREATE PROCEDURE insert_new_dummy()
BEGIN
	INSERT INTO employees(
        birth_date,
        first_name,
        last_name,
        gender,
        hire_date
    )
VALUES(
    '1970-01-01',
    'foo',
    'bar',
    'M',
    CURDATE()) ;
END //
DELIMITER ;

--4
DELIMITER
    //
CREATE PROCEDURE update_salary
(IN perno INT,
 IN newsalary INT)
BEGIN
UPDATE
    salaries
SET
    salary = newsalary
WHERE
    emp_no = perno;
END //
DELIMITER ;

--5
DELIMITER
    //
CREATE PROCEDURE create_dumb_view()
BEGIN
    CREATE VIEW dumb_view AS SELECT
        *
    FROM
        dept_emp;
END //
DELIMITER
    ;
-- Det giver ikke meget mening at gøre dette, plus mysql er ikke glad for det.
 