create database crud;

use crud;


CREATE TABLE IF NOT EXISTS `crud`.`Stands` (
  `idStands` INT NOT NULL AUTO_INCREMENT,
  `nameStand` VARCHAR(45) NULL,
  `typeStand` VARCHAR(45) NULL,
  `userStand` VARCHAR(45) NULL,
  PRIMARY KEY (`idStands`));

select * from Stands;