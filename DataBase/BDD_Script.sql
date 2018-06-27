#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Ventes
#------------------------------------------------------------

CREATE TABLE Ventes(
        NumVente     int (11) Auto_increment  NOT NULL ,
        DateVente    Datetime NOT NULL ,
        MontantVente DECIMAL (15,3)  NOT NULL ,
        PRIMARY KEY (NumVente )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Familles
#------------------------------------------------------------

CREATE TABLE Familles(
        CodeFamille int (11) Auto_increment  NOT NULL ,
        Designation Varchar (100) NOT NULL ,
        PRIMARY KEY (CodeFamille ) ,
        UNIQUE (Designation )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Stocks
#------------------------------------------------------------

CREATE TABLE Stocks(
        NumStock           int (11) Auto_increment  NOT NULL ,
        QuantiteMedicament Int NOT NULL ,
        PRIMARY KEY (NumStock )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Medicaments
#------------------------------------------------------------

CREATE TABLE Medicaments(
        CodeMedicament    int (11) Auto_increment  NOT NULL ,
        LibelleMedicament Varchar (100) NOT NULL ,
        Prix              DECIMAL (15,3)  NOT NULL ,
        CodeFamille       Int NOT NULL ,
        PRIMARY KEY (CodeMedicament )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Users
#------------------------------------------------------------

CREATE TABLE Users(
        UserId   int (11) Auto_increment  NOT NULL ,
        Login    Varchar (50) NOT NULL ,
        Password Varchar (50) NOT NULL ,
        Name     Varchar (50) NOT NULL ,
        PRIMARY KEY (UserId ) ,
        UNIQUE (Password )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: StockMedis
#------------------------------------------------------------

CREATE TABLE StockMedis(
        QuantiteMedicament Int NOT NULL ,
        NumStock           Int NOT NULL ,
        CodeMedicament     Int NOT NULL ,
        PRIMARY KEY (NumStock ,CodeMedicament )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: VenteMedis
#------------------------------------------------------------

CREATE TABLE VenteMedis(
        QuantiteMedicament Int NOT NULL ,
        NumVente           Int NOT NULL ,
        CodeMedicament     Int NOT NULL ,
        PRIMARY KEY (NumVente ,CodeMedicament )
)ENGINE=InnoDB;

ALTER TABLE Medicaments ADD CONSTRAINT FK_Medicaments_CodeFamille FOREIGN KEY (CodeFamille) REFERENCES Familles(CodeFamille);
ALTER TABLE StockMedis ADD CONSTRAINT FK_StockMedis_NumStock FOREIGN KEY (NumStock) REFERENCES Stocks(NumStock);
ALTER TABLE StockMedis ADD CONSTRAINT FK_StockMedis_CodeMedicament FOREIGN KEY (CodeMedicament) REFERENCES Medicaments(CodeMedicament);
ALTER TABLE VenteMedis ADD CONSTRAINT FK_VenteMedis_NumVente FOREIGN KEY (NumVente) REFERENCES Ventes(NumVente);
ALTER TABLE VenteMedis ADD CONSTRAINT FK_VenteMedis_CodeMedicament FOREIGN KEY (CodeMedicament) REFERENCES Medicaments(CodeMedicament);
