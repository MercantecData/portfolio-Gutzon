USE gamestore;

ALTER TABLE store_location
ADD COLUMN earnings INT;

UPDATE store_location SET earnings = 65000 WHERE name = 'Aalborg';
UPDATE store_location SET earnings = 83000 WHERE name = 'Viborg';
UPDATE store_location SET earnings = 65000 WHERE name = 'København';

INSERT INTO physical_items(itemID, locationID) VALUES
(1,1),(3,2),(1,1),(1,1),(1,1),
(1,1),(2,2),(1,1),(3,1),(2,1);


-- Udfordringer:

-- For navn på spil og stock af det spil
SELECT
        items.NAME,
        COUNT(*) as stock
    FROM
        items
    INNER JOIN physical_items ON physical_items.itemID = items.id
    GROUP BY NAME


