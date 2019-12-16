DELIMITER
    //
CREATE PROCEDURE generate_user_and_database(
    IN username TEXT,
    IN kode TEXT
)
BEGIN
	PREPARE stmt1 FROM CONCAT('CREATE USER ', username);
	EXECUTE stmt1 ;
	DEALLOCATE PREPARE stmt1 ;
	PREPARE stmt2 FROM CONCAT('SET PASSWORD FOR ', username, ' = PASSWORD(\'',kode,'\')');
	EXECUTE stmt2 ;
	DEALLOCATE PREPARE stmt2 ;
	PREPARE stmt3 FROM CONCAT('CREATE DATABASE ', username,'_db');
	EXECUTE stmt3 ;
	DEALLOCATE PREPARE stmt3 ;
	PREPARE stmt4 FROM CONCAT('GRANT SELECT ON *.* TO ', username);
	EXECUTE stmt4 ;
	DEALLOCATE PREPARE stmt4 ;
	PREPARE stmt5 FROM CONCAT('GRANT ALL ON ',username,'_db TO ', username);
	EXECUTE stmt5 ;
	DEALLOCATE PREPARE stmt5 ;
END //
