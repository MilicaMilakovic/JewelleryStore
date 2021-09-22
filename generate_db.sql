-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema store_db
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `store_db` ;

-- -----------------------------------------------------
-- Schema store_db
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `store_db` DEFAULT CHARACTER SET utf8 ;
USE `store_db` ;

-- -----------------------------------------------------
-- Table `store_db`.`ZAPOSLENI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `store_db`.`ZAPOSLENI` (
  `idZaposlenog` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NOT NULL,
  `Prezime` VARCHAR(45) NOT NULL,
  `KorisnickoIme` VARCHAR(45) NOT NULL,
  `Lozinka` VARCHAR(45) NOT NULL,
  `ZaposlenOd` DATE NOT NULL,
  `Plata` DECIMAL(6,2) NOT NULL,
  `isAdmin` TINYINT(1) NOT NULL,
  `isActive` TINYINT(1) NOT NULL,
  PRIMARY KEY (`idZaposlenog`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `store_db`.`RACUN`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `store_db`.`RACUN` (
  `idRacuna` INT NOT NULL,
  `DatumIzdavanja` DATETIME NOT NULL,
  `CijenaUkupno` DECIMAL(7,2) NOT NULL,
  `ZAPOSLENI_idZaposlenog` INT NOT NULL,
  PRIMARY KEY (`idRacuna`),
  INDEX `fk_RACUN_ZAPOSLENI1_idx` (`ZAPOSLENI_idZaposlenog` ASC) VISIBLE,
  CONSTRAINT `fk_RACUN_ZAPOSLENI1`
    FOREIGN KEY (`ZAPOSLENI_idZaposlenog`)
    REFERENCES `store_db`.`ZAPOSLENI` (`idZaposlenog`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `store_db`.`TIP_PROIZVODA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `store_db`.`TIP_PROIZVODA` (
  `idTipaProizvoda` INT NOT NULL,
  `Tip` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTipaProizvoda`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `store_db`.`PROIZVOD`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `store_db`.`PROIZVOD` (
  `SifraProizvoda` INT NOT NULL,
  `Naziv` VARCHAR(45) NOT NULL,
  `Cijena` DECIMAL(6,2) NOT NULL,
  `Kolicina` INT NOT NULL,
  `Slika` VARCHAR(150) NULL,
  `Opis` VARCHAR(45) NULL,
  `tipProizvoda` INT NOT NULL,
  PRIMARY KEY (`SifraProizvoda`),
  INDEX `fk_PROIZVOD_TIP_PROIZVODA_idx` (`tipProizvoda` ASC) VISIBLE,
  CONSTRAINT `fk_PROIZVOD_TIP_PROIZVODA`
    FOREIGN KEY (`tipProizvoda`)
    REFERENCES `store_db`.`TIP_PROIZVODA` (`idTipaProizvoda`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `store_db`.`RACUN_STAVKA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `store_db`.`RACUN_STAVKA` (
  `SifraProizvoda` INT NOT NULL,
  `idRacuna` INT NOT NULL,
  `Kolicina` INT NOT NULL,
  `Cijena` DECIMAL(6,2) NOT NULL,
  PRIMARY KEY (`SifraProizvoda`, `idRacuna`),
  INDEX `fk_PROIZVOD_has_RACUN_RACUN1_idx` (`idRacuna` ASC) VISIBLE,
  INDEX `fk_PROIZVOD_has_RACUN_PROIZVOD1_idx` (`SifraProizvoda` ASC) VISIBLE,
  CONSTRAINT `fk_PROIZVOD_has_RACUN_PROIZVOD1`
    FOREIGN KEY (`SifraProizvoda`)
    REFERENCES `store_db`.`PROIZVOD` (`SifraProizvoda`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PROIZVOD_has_RACUN_RACUN1`
    FOREIGN KEY (`idRacuna`)
    REFERENCES `store_db`.`RACUN` (`idRacuna`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
