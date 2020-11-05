------------------------------------------------------------------------------------------------------------------------------------
--															INSTRUCTIONS
------------------------------------------------------------------------------------------------------------------------------------

-- Create each insert separately

------------------------------------------------------------------------------------------------------------------------------------

USE Multinational

-- Head Offices
INSERT INTO HeadOffice VALUES ('Sede Local A')
INSERT INTO HeadOffice VALUES ('Sede Local B')
INSERT INTO HeadOffice VALUES ('Sede Local C')
INSERT INTO HeadOffice VALUES ('Sede Local D')

-- Products
INSERT INTO Product VALUES ('Product 1', 123)
INSERT INTO Product VALUES ('Product 2', 45.67)
INSERT INTO Product VALUES ('Product 3', 89)
INSERT INTO Product VALUES ('Product 4', 100.99)
INSERT INTO Product VALUES ('Product 5', 97)
INSERT INTO Product VALUES ('Product 6', 584.12)
INSERT INTO Product VALUES ('Product 7', 456)
INSERT INTO Product VALUES ('Product 8', 20.50)
INSERT INTO Product VALUES ('Product 9', 1238)
INSERT INTO Product VALUES ('Product 10', 2345.50)

-- Clients
    -- Head Office A
INSERT INTO Client VALUES ('Client A1', 1) -- Head Offices A 
INSERT INTO Client VALUES ('Client A2', 1) -- Head Offices A
INSERT INTO Client VALUES ('Client A3', 1) -- Head Offices A
INSERT INTO Client VALUES ('Client A4', 1) -- Head Offices A
INSERT INTO Client VALUES ('Client A5', 1) -- Head Offices A

    -- Head Office B
INSERT INTO Client VALUES ('Client B1', 2) -- Head Offices B
INSERT INTO Client VALUES ('Client B2', 2) -- Head Offices B
INSERT INTO Client VALUES ('Client B3', 2) -- Head Offices B
INSERT INTO Client VALUES ('Client B4', 2) -- Head Offices B
INSERT INTO Client VALUES ('Client B5', 2) -- Head Offices B

    -- Head Office C
INSERT INTO Client VALUES ('Client C1', 3) -- Head Offices C
INSERT INTO Client VALUES ('Client C2', 3) -- Head Offices C
INSERT INTO Client VALUES ('Client C3', 3) -- Head Offices C
INSERT INTO Client VALUES ('Client C4', 3) -- Head Offices C
INSERT INTO Client VALUES ('Client C5', 3) -- Head Offices C

    -- Head Office D
INSERT INTO Client VALUES ('Client D1', 4) -- Head Offices D
INSERT INTO Client VALUES ('Client D2', 4) -- Head Offices D
INSERT INTO Client VALUES ('Client D3', 4) -- Head Offices D
INSERT INTO Client VALUES ('Client D4', 4) -- Head Offices D
INSERT INTO Client VALUES ('Client D5', 4) -- Head Offices D

-- Sales
    -- Head Office A
INSERT INTO Sale VALUES (123, 1, 1) -- Client A1
INSERT INTO Sale VALUES (168.67, 2, 1) -- Client A2
INSERT INTO Sale VALUES (257.67, 3, 1) -- Client A3
INSERT INTO Sale VALUES (358.66, 4, 1) -- Client A4

    -- Head Office B
INSERT INTO Sale VALUES (455.66, 6, 2) -- Client B1
INSERT INTO Sale VALUES (2298.62, 7, 2) -- Client B2
INSERT INTO Sale VALUES (2514.17, 8, 2) -- Client B3
INSERT INTO Sale VALUES (189.99, 9, 2) -- Client B4

    -- Head Office C
INSERT INTO Sale VALUES (97, 11, 3) -- Client C1
INSERT INTO Sale VALUES (1040.12, 12, 3) -- Client C2
INSERT INTO Sale VALUES (3604, 13, 3) -- Client C3
INSERT INTO Sale VALUES (358.66, 14, 3) -- Client C4

    -- Head Office D
INSERT INTO Sale VALUES (2395.62, 16, 4) -- Client D1
INSERT INTO Sale VALUES (2603.17, 17, 4) -- Client D2
INSERT INTO Sale VALUES (782.11, 18, 4) -- Client D3
INSERT INTO Sale VALUES (456, 19, 4) -- Client D4

-- Items
    -- Client A1
INSERT INTO Item VALUES (1,1,1) -- Product 1 / Sale 1

    -- Client A2
INSERT INTO Item VALUES (1,2,1) -- Product 1 / Sale 2
INSERT INTO Item VALUES (1,2,2) -- Product 2 / Sale 2

    -- Client A3
INSERT INTO Item VALUES (1,3,1) -- Product 1 / Sale 3
INSERT INTO Item VALUES (1,3,2) -- Product 2 / Sale 3
INSERT INTO Item VALUES (1,3,3) -- Product 3 / Sale 3

    -- Client A4
INSERT INTO Item VALUES (1,4,2) -- Product 2 / Sale 4
INSERT INTO Item VALUES (1,4,1) -- Product 1 / Sale 4
INSERT INTO Item VALUES (1,4,3) -- Product 3 / Sale 4
INSERT INTO Item VALUES (1,4,4) -- Product 4 / Sale 4

    -- Client B1
INSERT INTO Item VALUES (1,5,1) -- Product 1 / Sale 5
INSERT INTO Item VALUES (1,5,2) -- Product 2 / Sale 5
INSERT INTO Item VALUES (1,5,3) -- Product 3 / Sale 5
INSERT INTO Item VALUES (1,5,4) -- Product 4 / Sale 5
INSERT INTO Item VALUES (1,5,5) -- Product 5 / Sale 5

    -- Client B2
INSERT INTO Item VALUES (1,6,6) -- Product 6 / Sale 6
INSERT INTO Item VALUES (1,6,7) -- Product 7 / Sale 6
INSERT INTO Item VALUES (1,6,8) -- Product 8 / Sale 6
INSERT INTO Item VALUES (1,6,9) -- Product 9 / Sale 6

    -- Client B3
INSERT INTO Item VALUES (1,7,10) -- Product 10 / Sale 7
INSERT INTO Item VALUES (1,7,1) -- Product 1 / Sale 7
INSERT INTO Item VALUES (1,7,2) -- Product 2 / Sale 7

    -- Client B4
INSERT INTO Item VALUES (1,8,3) -- Product 3 / Sale 8
INSERT INTO Item VALUES (1,8,4) -- Product 4 / Sale 8

    -- Client C1
INSERT INTO Item VALUES (1,9,5) -- Product 5 / Sale 9

    -- Client C2
INSERT INTO Item VALUES (1,10,6) -- Product 6 / Sale 10
INSERT INTO Item VALUES (1,10,7) -- Product 7 / Sale 10

    -- Client C3
INSERT INTO Item VALUES (1,11,8) -- Product 8 / Sale 11
INSERT INTO Item VALUES (1,11,9) -- Product 9 / Sale 11
INSERT INTO Item VALUES (1,11,10) -- Product 10 / Sale 11

    -- Client C4
INSERT INTO Item VALUES (1,12,1) -- Product 1 / Sale 12
INSERT INTO Item VALUES (1,12,2) -- Product 2 / Sale 12
INSERT INTO Item VALUES (1,12,3) -- Product 3 / Sale 12
INSERT INTO Item VALUES (1,12,4) -- Product 4 / Sale 12

    -- Client D1
INSERT INTO Item VALUES (1,13,5) -- Product 5 / Sale 13
INSERT INTO Item VALUES (1,13,6) -- Product 6 / Sale 13
INSERT INTO Item VALUES (1,13,7) -- Product 7 / Sale 13
INSERT INTO Item VALUES (1,13,8) -- Product 8 / Sale 13
INSERT INTO Item VALUES (1,13,9) -- Product 9 / Sale 13

    -- Client D2
INSERT INTO Item VALUES (1,14,10) -- Product 10 / Sale 14
INSERT INTO Item VALUES (1,14,1) -- Product 1 / Sale 14
INSERT INTO Item VALUES (1,14,2) -- Product 2 / Sale 14
INSERT INTO Item VALUES (1,14,3) -- Product 3 / Sale 14

    -- Client D3
INSERT INTO Item VALUES (1,15,4) -- Product 4 / Sale 15
INSERT INTO Item VALUES (1,15,5) -- Product 5 / Sale 15
INSERT INTO Item VALUES (1,15,6) -- Product 6 / Sale 15

    -- Client D4
INSERT INTO Item VALUES (1,16,7) -- Product 7 / Sale 16