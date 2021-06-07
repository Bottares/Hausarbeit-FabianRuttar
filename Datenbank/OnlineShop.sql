IF DB_ID('OnlineShopDB') IS NULL
  CREATE DATABASE OnlineShopDB;
GO

if OBJECT_ID('Kunde') IS NOT NULL
	DROP TABLE Kunde;

if OBJECT_ID('Produkt') IS NOT NULL
	DROP TABLE Produkt;

if OBJECT_ID('Produktkategorie') IS NOT NULL
	DROP TABLE Produktkategorie;

if OBJECT_ID('OnlineShop') IS NOT NULL
	DROP TABLE OnlineShop;

if OBJECT_ID('Bestellung') IS NOT NULL
	DROP TABLE Bestellung;

if OBJECT_ID('Rückgabe') IS NOT NULL
	DROP TABLE Rückgabe;

USE OnlineShopDB
GO

CREATE TABLE Produktkategorie
(
	KategorieID INT PRIMARY KEY,
	Name NVARCHAR(100)
);

CREATE TABLE OnlineShop
(
	Name NVARCHAR(100) PRIMARY KEY,
	Ort NVARCHAR(100),
	Postleitzahl NVARCHAR(100),
	Straße NVARCHAR(100),
	Hausnummer NVARCHAR(100)
);

CREATE TABLE Produkt
(
	ProduktID INT PRIMARY KEY,
	ArtikelNummer NVARCHAR(10),
	ProduktName NVARCHAR(100),
	Beschreibung NVARCHAR(200),
	Preis NVARCHAR(100),
	Bild NVARCHAR(200),	
	KategorieID INT FOREIGN KEY REFERENCES Produktkategorie(KategorieID)
);

CREATE TABLE Kunde
(
	Email NVARCHAR(100) PRIMARY KEY,
	Passwort NVARCHAR(100),
	Anrede NVARCHAR(100),
	Vorname NVARCHAR(100),
	Nachname NVARCHAR(100),
	Geburtsdatum NVARCHAR(100),
	Ort NVARCHAR(100),
	Postleitzahl NVARCHAR(100),
	Straße_HausNr NVARCHAR(100),
	Land NVARCHAR(100)
);

CREATE TABLE Bestellung
(
	BestellungsID INT PRIMARY KEY,
	Bestelldatum DATETIME,
	Menge INT,
	Preis NVARCHAR(100),
	Bestellstatus NVARCHAR(100),
);

CREATE TABLE Rückgabe
(
	Email NVARCHAR(100) PRIMARY KEY,
	Rechnungsnummer NVARCHAR(100),
	Artikelnummer NVARCHAR(100),
	Kommentar NVARCHAR(500)
);

INSERT INTO Produktkategorie(KategorieID, Name)
VALUES ('1', 'OFFICE-PC'),
	   ('2', 'GAMING-PC'),
	   ('3', 'PC-MONITOR'),
	   ('4', 'NOTEBOOK'),
	   ('5', 'HARDWARE');

INSERT INTO OnlineShop(Name, Ort, Postleitzahl, Straße, Hausnummer)
VALUES ('PC Nation', 'Saarbrücken', '66121', 'Musterstraße', '117');

INSERT INTO Produkt(ProduktID, ArtikelNummer, ProduktName, Beschreibung, Preis, Bild)
VALUES ('1', '5510', 'Office PC Intel i3-10100', 'OFFICE PC INTEL i3-10100 4x 3.60GHz | 8GB DDR4 | NVIDIA GeForce GT 710 | 480GB SSD | Win 10 Home', '519,00€', 'https://www.memorypc.de/media/image/52/c5/e7/550442lJxxnDCmOlxJ6_600x600.png'),
	   ('2', '5511', 'Office PC Intel i5-9400F', 'OFFICE PC INTEL i5-9400F 6x 2.90GHz | 8GB DDR4 | NVIDIA GT 710 | 250GB SSD +1TB HDD | Win 10 Home', '529,00€','https://www.memorypc.de/media/image/bd/e9/cd/550443ytTwDTExyUVqu_600x600.png'),
	   ('3', '5512', 'Office PC AMD Ryzen 3 2200G', 'OFFICE PC AMD Ryzen 3 2200G 4x 3.50GHz | 8GB DDR4 2666 MHz | Radeon Vega 8 | 120GB HDD', '349,00€','https://www.memorypc.de/media/image/a5/19/3c/5537886PMu5bqoEGwxv_600x600.png'),
	   ('4', '5513', 'Office PC AMD A8-9600', 'OFFICE PC AMD A8-9600 4x 3.10GHz | 8GB DDR4 | Radeon R7 | 120GB SSD | Win 10 Home', '289,00€','https://www.memorypc.de/media/image/b8/2e/c8/550418iMnPXJKxRJbPT_600x600.png'),
	   ('5', '5514', 'Office PC Intel i7-9700K', 'OFFICE PC INTEL i7-9700K 8x 3.60GHz | 16GB DDR4 | UHD 630 | 240GB SSD +2TB HDD | Win 10 Home', '699,00€','https://www.memorypc.de/media/image/53/ea/42/550897P0GbT3v7YLDyx_600x600.png'),
	   ('6', '5515', 'Gaming PC Intel i5-10500', 'GAMING PC INTEL i5-10500 6x 3.10GHz | 8GB DDR4 | GTX 1650 | 120GB SSD +1TB HDD', '819,00€','https://www.memorypc.de/media/image/97/fd/81/550641DHVwzwbFADyXg_600x600.png'),
	   ('7', '5516', 'Gaming PC Intel i7-11700K', 'GAMING PC INTEL i7-11700K 8x 3.60GHz | 16GB DDR4 | RTX 2060 | 480GB SSD +1TB HDD | Win 10 Home', '1.579,00€','https://www.memorypc.de/media/image/9a/e2/d1/553980uQnY0f6bxnZPD_600x600.png'),
	   ('8', '5517', 'Gaming PC Battlebox AMD Ryzen 7 3700X', 'GAMING PC GeForce RTX Battlebox AMD Ryzen 7 3700X 8x 3.60GHz | 16GB DDR4 | RTX 3070 | 480GB SSD +2TB HDD', '1.849,00€','https://www.memorypc.de/media/image/c4/af/17/552130wQWWPVvCky8Hc_600x600.png'),
	   ('9', '5518', 'Gaming PC AMD Ryzen 5 3600', 'GAMING PC AMD Ryzen 5 3600 6x 3.60GHz | 8GB DDR4 | GTX 1650 | 240GB SSD +1TB HDD', '799,00€','https://www.memorypc.de/media/image/a6/9f/17/550301_600x600.png'),
	   ('10', '5519', 'Gaming PC AMD Ryzen 5 5600X', 'GAMING PC AMD Ryzen 5 5600X 6x 3.70GHz | 16GB DDR4 | RTX 3070 8GB | 250GB +1TB HDD | Win 10 Home', '1.879,00€','https://www.memorypc.de/media/image/db/fb/83/552904_600x600.png'),
	   ('11', '5520', 'Acer Value V6 V226HQLBbd - LED-Monitor', '21.5" (54.6cm) Acer Value V6 V226HQLBbd - LED-Monitor - VGA, DVI', '99,00€','https://www.memorypc.de/media/image/e4/25/b4/552827yMjkbtEBUS6fL_600x600.png'),
	   ('12', '5521', 'ASUS VA249HE - LED-Monitor', '23.8" (60.5cm) ASUS VA249HE - LED-Monitor - VGA, HDMI - 60Hz', '119,00€','https://www.memorypc.de/media/image/08/58/94/6364162000jyFsBS48YFlkp_600x600.png'),
	   ('13', '5522', 'HP 27f - LED-Monitor', '27" (68.6cm) HP 27f - LED-Monitor, 1x VGA, 2x HDMI 2.0', '159,00€','https://www.memorypc.de/media/image/4d/f2/3a/hp_24fw_neuqQHg4BiizKmcr_600x600.png'),
	   ('14', '5523', 'MSI Optix G241VC - LED-Monitor', '23.6" (59.9cm) MSI Optix G241VC - LED-Monitor - Curved - 75Hz - HDMI, VGA', '163,00€','https://www.memorypc.de/media/image/6f/17/26/552044Vlbg83bI60Jig_600x600.png'),
	   ('15', '5524', 'DELL P2419H - LED-Monitor', '23.8" (60.5cm) DELL P2419H - LED-Monitor - HDMI, VGA', '172,00€','https://media.nbb-cdn.de/images/products/370000/377462/p2419h_lfp_00000f000_gy.psd.thumb.1280.1280.1533248816000.jpg?size=400'),
	   ('16', '5525', 'Philips 327E8QJAB - LED-Monitor', '31.5" (80cm) Philips 327E8QJAB - LED-Monitor - HDMI, VGA', '239,00€','https://media.nbb-cdn.de/images/products/650000/652072/2163052-n0.jpg?size=400'),
	   ('17', '5526', 'Samsung C27F396 - LED-Monitor', '27" (68.6cm) Samsung C27F396 - LED-Monitor - Curved - HDMI, VGA', '169,00€','https://www.memorypc.de/media/image/ec/6a/1c/551031_600x600.png'),
	   ('18', '5527', 'Samsung Odyssey G5 C32G54TQWU - LED-Monitor', '31.5" (80 cm) Samsung Odyssey G5 C32G54TQWU - LED-Monitor - 144Hz - Curved - HDMI, DisplayPort', '344,00€','https://www.memorypc.de/media/image/0e/7a/1e/553956auZMOLrmY7IBG_600x600.png'),
	   ('19', '5528', 'Gigabyte G32QC - LED-Monitor', '31.5" (80 cm) Gigabyte G32QC - LED-Monitor - 165 Hz - Curved - 2x HDMI, 1x DisplayPort', '399,00€','https://www.memorypc.de/media/image/da/2d/6f/553568VUhF5l7qvM6pA_600x600.png'),
	   ('20', '5529', 'Acer Predator XB1 XB271HUAbmiprz - LED-Monitor', '27" (68.6 cm ) Acer Predator XB1 XB271HUAbmiprz - LED-Monitor - 144Hz - HDMI, DisplayPort', '439,00€','https://www.memorypc.de/media/image/e4/7f/53/553902NZJ62TZG39CYp_600x600.png'),
	   ('21', '5530', 'Notebook Lenovo Chromebook S345-14AST', 'Lenovo Chromebook S345-14AST | AMD A6-9220C | Radeon R5 | 4GB RAM | 64GB Flash | Chrome OS', '279,00€','https://www.memorypc.de/media/image/6c/da/cb/553317SJ5T6uCXZCqj0_600x600.png'),
	   ('22', '5531', 'Notebook Lenovo Slim 11"', 'Lenovo Slim 11" | AMD A6-9220e | 4GB RAM | 64GB SSD | Windows 10 Home S', '249,00€','https://www.memorypc.de/media/image/5c/cc/57/552586_600x600.png'),
	   ('23', '5532', 'Notebook Lenovo V14-ADA', 'Lenovo V14-ADA | AMD 3020e | AMD Radeon Graphics | 8GB RAM | 256GB M.2 SSD | Windows 10 Home', '399,00€','https://www.memorypc.de/media/image/ab/fc/19/553963dFMENPBKxhmq2_600x600.png'),
	   ('24', '5533', 'Notebook ASUS F515JA-BQ706', 'ASUS F515JA-BQ706 | Intel i3-1005G1 | UHD Graphics | 4GB RAM | 256GB SSD', '449,00€','https://www.memorypc.de/media/image/2f/a9/68/5539219DDcH0cOXBOJH_600x600.png'),
	   ('25', '5534', 'Notebook Lenovo V15-ADA', 'Lenovo V15-ADA | AMD Athlon 3050U | Radeon Graphics | 4GB RAM | 256GB M.2 SSD', '289,00€','https://www.memorypc.de/media/image/56/81/d0/552608lzkOFvHv6EIvy_600x600.png'),
	   ('26', '5535', 'Notebook OB-Ware', 'OB-Ware | ASUS F509JA-EJ294 | Intel Core i5-1035G1 | UHD Graphics | 4GB RAM | 256GB SSD', '469,00€','https://www.memorypc.de/media/image/19/62/0b/553233Xov6J4SzGhfBM_600x600.png'),
	   ('27', '5536', 'Notebook Acer Aspire 3 A315-23-R0XR', 'Acer Aspire 3 A315-23-R0XR | AMD Ryzen 3 3250U | Radeon Graphics | 8GB RAM | 256GB M.2 SSD | Windows 10 S', '499,00€','https://www.memorypc.de/media/image/96/07/86/553682iuElsk5eoINHT_600x600.png'),
	   ('28', '5537', 'Notebook HP 17-ca2411ng', 'HP 17-ca2411ng | AMD Athlon 3050U | AMD Radeon Graphics | 8GB RAM | 1TB HDD | Windows 10 Pro', '499,00€','https://www.memorypc.de/media/image/c4/3d/f2/hp250g6_1mckrMfTapZka4_600x600.png'),
	   ('29', '5538', 'Notebook DELL Inspiron 14 5402', 'DELL Inspiron 14 5402 | Intel Core i5-1135G7 | Iris Xe Graphics | 8GB RAM | 512GB M.2 SSD | Windows 10 Home', '749,00€','https://www.memorypc.de/media/image/d9/ac/8a/553382_600x600.png'),
	   ('30', '5539', 'Notebook ASUS TUF Gaming A15 FA506IV-HN196', 'ASUS TUF Gaming A15 FA506IV-HN196 | Ryzen 7 4800H | RTX 2060 | 8GB RAM | 512GB M.2 SSD', '1.249,00€','https://www.memorypc.de/media/image/1d/g0/95/552554IoY3HW1ImodvS_600x600.png'),
	   ('31', '5540', 'Microsoft Office Personal 365 Tage Office', 'Microsoft Office Personal 365 Tage Office, PKC (deutsch)', '57,00€','https://www.memorypc.de/media/image/2a/75/d0/5501387Q47RfwbWvlqQ_600x600.png'),
	   ('32', '5541', 'Microsoft Office Home & Student 2019 (1PC)', 'Microsoft Office Home & Student 2019 (1PC)', '141,00€','https://www.memorypc.de/media/image/64/96/9a/550421_600x600.png'),
	   ('33', '5542', 'Microsoft Office 2019 Home and Business', 'Microsoft Office 2019 Home and Business, PKC (deutsch)', '262,00€','https://www.memorypc.de/media/image/9a/e8/5e/552885_600x600.png'),
	   ('34', '5543', 'Sharkoon 1337 Gaming Mousepad', 'Sharkoon 1337 Gaming Mousepad - Größe L', '6,00€','https://www.memorypc.de/media/image/cf/b0/7d/551815_600x600.png'),
	   ('35', '5544', 'Sharkoon B1 Gaming Headset', 'Sharkoon Gaming Headset B1 schwarz', '43,00€','https://www.memorypc.de/media/image/66/a6/60/552195_600x600.png'),
	   ('36', '5545', 'Sharkoon Light² 200 Gaming Maus', 'Sharkoon Light² 200, USB Gaming Maus', '53,00€','https://www.memorypc.de/media/image/24/ff/6f/552855_600x600.png'),
	   ('37', '5546', 'Sharkoon Skiller SGM1 Gaming Maus', 'Sharkoon Skiller SGM1 Gaming Maus 10800dpi, USB', '23,00€','https://www.memorypc.de/media/image/d7/02/7a/553438_600x600.png'),
	   ('38', '5547', 'Logitech Z533 Lautsprecher', 'Logitech Z533 Lautsprecher 2.1 mit Subwoofer', '110,00€','https://www.memorypc.de/media/image/7e/3a/61/Logitech-Z533HOfNxNDAOXJaB_600x600.png'),
	   ('39', '5548', 'DeLOCK USB-Hub', 'DeLOCK USB-Hub, 4x USB-A 3.0', '16,00€','https://www.memorypc.de/media/image/f8/67/9b/552207EHLO2UHi7ZE1N_600x600.png'),
	   ('40', '5549', '32GB Intenso Speed Line USB Stick', '32GB Intenso Speed Line, USB Stick', '6,00€','https://www.memorypc.de/media/image/30/a1/08/551787_600x600.png');

INSERT INTO Kunde(Email, Passwort, Anrede, Vorname, Nachname, Geburtsdatum, Ort, Postleitzahl, Straße_HausNr, Land)
VALUES ('p.Schmitt@gmail.com', '1234', 'Herr', 'Peter', 'Schmitt', '09.05.1985', 'Saarbrücken',  '66121', 'Blumenstraße 34', 'Deutschland'),
	   ('k.Peter@gmail.com', 'Hund123', 'Herr', 'Klaus', 'Peter', '07.03.1990', 'Metz', '57000', 'Rue Clovis 5', 'Frankreich'),
	   ('s.Stark@gmail.com', 'Katze44', 'Frau', 'Sarah', 'Stark', '11.06.1996', 'Wien', '1080', 'Zeltgasse 14', 'Österreich'),
	   ('t.Merte@gmail.com', 'Ford86', 'Herr', 'Thomas', 'Merte', '22.11.1986', 'Brüssel', '1082', 'Rue Hubert Blauwet 41', 'Belgien'),
	   ('r.Pancini@gmail.com', 'Hase123', 'Frau', 'Rosa', 'Pancini', '03.01.1992', 'Rom', '00165', 'Via Pio IV 52', 'Italien');
