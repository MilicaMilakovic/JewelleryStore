select * from zaposleni;
INSERT INTO `store_db`.`zaposleni` (`Ime`, `Prezime`, `KorisnickoIme`, `Lozinka`, `ZaposlenOd`, `Plata`, `isAdmin`, `isActive`) VALUES ('Milica', 'Milakovic', 'milica', 'milica', '2021-09-22', '1000', '0', '1');
INSERT INTO `store_db`.`zaposleni` (`Ime`, `Prezime`, `KorisnickoIme`, `Lozinka`, `ZaposlenOd`, `Plata`, `isAdmin`, `isActive`) VALUES ('Marko', 'Markovic', 'admin', 'admin', '2021-09-27', '1000', '1', '1');
INSERT INTO `store_db`.`zaposleni` (`Ime`, `Prezime`, `KorisnickoIme`, `Lozinka`, `ZaposlenOd`, `Plata`, `isAdmin`, `isActive`) VALUES ('Test', 'Test', 'test', 'test', '2021-09-27', '1000', '0', '1');

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

INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Moonphase Ivory Gold Ring', '65.25', '125', 'MoonphaseIvoryGoldRing.jpg', '2');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Moonphase Mauve Gold Ring', '65.25', '125', 'MoonphaseMauveGoldRing.jpg', '2');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Presence Ring', '67.50', '125', 'PresenceRing.jpg', '2');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Rainbow Ring', '68.70', '125', 'Rainbowringtset.jpg', '2');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Unfold Heart Signet Ring ', '68.90', '125', 'UnfoldHeartsignetringivory.jpg', '2');

INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Heartseeker Hoop Earrings', '81.26', '125', 'Heartseekerhoopearrings.jpg', '3');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Star Taupe Hoop Earrings', '81.30', '125', 'StarTaupeHoopEarrings.jpg', '3');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Sunlit Drop Earrings', '83.34', '125', 'SunlitDropEarrings.jpg', '3');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Sun Peach Huggie Earrings', '84.27', '125', 'SunPeachHuggieEarrings.jpg', '3');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Sunseeker Gold Earrings', '81.26', '125', 'SunseekerGoldEarrings.jpg', '3');

INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Crescent Key Bracelet', '73.50', '125', 'CrescentKeyBracelet.jpg', '4');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Out of This World Bracelet', '75.25', '125', 'OutofThisWorldBracelet.jpg', '4');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Star Ivory Bracelet', '75.25', '125', 'StarIvoryBracelet.jpg', '4');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Starlit Bracelet', '73.81', '125', 'StarlitBracelet.jpg', '4');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Star Navy Bracelet', '73.91', '125', 'StarNavyBracelet.jpg', '4');
INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `tipProizvoda`) VALUES ('Sunseeker Bracelet', '74.91', '125', 'SunseekerBracelet.jpg', '4');


INSERT INTO `store_db`.`proizvod` (`Naziv`, `Cijena`, `Kolicina`, `Slika`, `isActive`, `tipProizvoda`) VALUES ('Test', '100', '125', '1.jpg', '1', '4');

select * from racun;
select * from racun_stavka;
select * from zaposleni;
select * from proizvod;