select * from zaposleni;
INSERT INTO `store_db`.`zaposleni` (`Ime`, `Prezime`, `KorisnickoIme`, `Lozinka`, `ZaposlenOd`, `Plata`, `isAdmin`, `isActive`) VALUES ('Milica', 'Milakovic', 'milica', 'milica', '2021-09-22', '1000', '0', '1');

select * from tip_proizvoda;
INSERT INTO `store_db`.`tip_proizvoda` (`Tip`) VALUES ('Necklace');
INSERT INTO `store_db`.`tip_proizvoda` (`Tip`) VALUES ('Ring');
INSERT INTO `store_db`.`tip_proizvoda` (`Tip`) VALUES ('Earring');
INSERT INTO `store_db`.`tip_proizvoda` (`Tip`) VALUES ('Wristwear');

select * from proizvod;
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Air Element Gold Necklace', '81.70', '125', 'AirElementGoldNecklace.jpg', '1');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Water Element Gold Necklace', '81.70', '125', 'WaterElementGoldNecklace.jpg', '1');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Earth Element Gold Necklace', '81.70', '125', 'EarthElementGoldNecklace.jpg', '1');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Fire Element Gold Necklace', '81.70', '125', 'FireElementGoldNecklace.jpg', '1');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Today Necklace', '81.70', '125', 'TodayNecklace.jpg', '1');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Universe Necklace', '81.70', '125', 'UniverseNecklace.jpg', '1');

