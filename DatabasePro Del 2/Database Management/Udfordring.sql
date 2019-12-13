DELIMITER
    //
CREATE PROCEDURE generate_user_and_database(
    IN username TEXT,
    IN kode TEXT
)
BEGIN
    CREATE USER username ; 
	SET PASSWORD FOR username = PASSWORD('kode');
    CREATE DATABASE username_db ; 
	GRANT SELECT ON *.* TO username ;
GRANT ALL ON username_db.* TO username ;
END //

