
SET QUOTED_IDENTIFIER OFF;
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'pharmaDB')
    BEGIN
        CREATE DATABASE pharmaDB
    END
GO
USE [pharmaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Medicaments_CodeFamille]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medicaments] DROP CONSTRAINT [FK_Medicaments_CodeFamille];
GO
IF OBJECT_ID(N'[dbo].[FK_StockMedi_CodeMedicament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StockMedis] DROP CONSTRAINT [FK_StockMedi_CodeMedicament];
GO
IF OBJECT_ID(N'[dbo].[FK_VenteMedi_CodeMedicament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VenteMedis] DROP CONSTRAINT [FK_VenteMedi_CodeMedicament];
GO
IF OBJECT_ID(N'[dbo].[FK_StockMedi_NumStock]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StockMedis] DROP CONSTRAINT [FK_StockMedi_NumStock];
GO
IF OBJECT_ID(N'[dbo].[FK_VenteMedi_NumVente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VenteMedis] DROP CONSTRAINT [FK_VenteMedi_NumVente];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Familles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Familles];
GO
IF OBJECT_ID(N'[dbo].[Medicaments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medicaments];
GO
IF OBJECT_ID(N'[dbo].[Stocks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stocks];
GO
IF OBJECT_ID(N'[dbo].[StockMedis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StockMedis];
GO
IF OBJECT_ID(N'[dbo].[Ventes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ventes];
GO
IF OBJECT_ID(N'[dbo].[VenteMedis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VenteMedis];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Familles'
CREATE TABLE [dbo].[Familles] (
    [CodeFamille] int IDENTITY(1,1) NOT NULL,
    [Designation] varchar(100)  NOT NULL
);
GO

-- Creating table 'Medicaments'
CREATE TABLE [dbo].[Medicaments] (
    [CodeMedicament] int IDENTITY(1,1) NOT NULL,
    [LibelleMedicament] varchar(100)  NOT NULL,
    [Prix] decimal(19,4)  NOT NULL,
    [CodeFamille] int  NOT NULL
);
GO

-- Creating table 'Stocks'
CREATE TABLE [dbo].[Stocks] (
    [NumStock] int IDENTITY(1,1) NOT NULL,
    [QuantiteMedicament] int  NOT NULL
);
GO

-- Creating table 'StockMedis'
CREATE TABLE [dbo].[StockMedis] (
    [QuantiteMedicament] int  NOT NULL,
    [NumStock] int  NOT NULL,
    [CodeMedicament] int  NOT NULL
);
GO

-- Creating table 'Ventes'
CREATE TABLE [dbo].[Ventes] (
    [NumVente] int IDENTITY(1,1) NOT NULL,
    [DateVente] datetime  NOT NULL,
    [MontantVente] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'VenteMedis'
CREATE TABLE [dbo].[VenteMedis] (
    [QuantiteMedicament] int  NOT NULL,
    [NumVente] int  NOT NULL,
    [CodeMedicament] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(50)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CodeFamille] in table 'Familles'
ALTER TABLE [dbo].[Familles]
ADD CONSTRAINT [PK_Familles]
    PRIMARY KEY CLUSTERED ([CodeFamille] ASC);
GO

-- Creating primary key on [CodeMedicament] in table 'Medicaments'
ALTER TABLE [dbo].[Medicaments]
ADD CONSTRAINT [PK_Medicaments]
    PRIMARY KEY CLUSTERED ([CodeMedicament] ASC);
GO

-- Creating primary key on [NumStock] in table 'Stocks'
ALTER TABLE [dbo].[Stocks]
ADD CONSTRAINT [PK_Stocks]
    PRIMARY KEY CLUSTERED ([NumStock] ASC);
GO

-- Creating primary key on [NumStock], [CodeMedicament] in table 'StockMedis'
ALTER TABLE [dbo].[StockMedis]
ADD CONSTRAINT [PK_StockMedis]
    PRIMARY KEY CLUSTERED ([NumStock], [CodeMedicament] ASC);
GO

-- Creating primary key on [NumVente] in table 'Ventes'
ALTER TABLE [dbo].[Ventes]
ADD CONSTRAINT [PK_Ventes]
    PRIMARY KEY CLUSTERED ([NumVente] ASC);
GO

-- Creating primary key on [NumVente], [CodeMedicament] in table 'VenteMedis'
ALTER TABLE [dbo].[VenteMedis]
ADD CONSTRAINT [PK_VenteMedis]
    PRIMARY KEY CLUSTERED ([NumVente], [CodeMedicament] ASC);
GO

-- Creating primary key on [UserId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CodeFamille] in table 'Medicaments'
ALTER TABLE [dbo].[Medicaments]
ADD CONSTRAINT [FK_Medicaments_CodeFamille]
    FOREIGN KEY ([CodeFamille])
    REFERENCES [dbo].[Familles]
        ([CodeFamille])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Medicaments_CodeFamille'
CREATE INDEX [IX_FK_Medicaments_CodeFamille]
ON [dbo].[Medicaments]
    ([CodeFamille]);
GO

-- Creating foreign key on [CodeMedicament] in table 'StockMedis'
ALTER TABLE [dbo].[StockMedis]
ADD CONSTRAINT [FK_StockMedi_CodeMedicament]
    FOREIGN KEY ([CodeMedicament])
    REFERENCES [dbo].[Medicaments]
        ([CodeMedicament])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StockMedi_CodeMedicament'
CREATE INDEX [IX_FK_StockMedi_CodeMedicament]
ON [dbo].[StockMedis]
    ([CodeMedicament]);
GO

-- Creating foreign key on [CodeMedicament] in table 'VenteMedis'
ALTER TABLE [dbo].[VenteMedis]
ADD CONSTRAINT [FK_VenteMedi_CodeMedicament]
    FOREIGN KEY ([CodeMedicament])
    REFERENCES [dbo].[Medicaments]
        ([CodeMedicament])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VenteMedi_CodeMedicament'
CREATE INDEX [IX_FK_VenteMedi_CodeMedicament]
ON [dbo].[VenteMedis]
    ([CodeMedicament]);
GO

-- Creating foreign key on [NumStock] in table 'StockMedis'
ALTER TABLE [dbo].[StockMedis]
ADD CONSTRAINT [FK_StockMedi_NumStock]
    FOREIGN KEY ([NumStock])
    REFERENCES [dbo].[Stocks]
        ([NumStock])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NumVente] in table 'VenteMedis'
ALTER TABLE [dbo].[VenteMedis]
ADD CONSTRAINT [FK_VenteMedi_NumVente]
    FOREIGN KEY ([NumVente])
    REFERENCES [dbo].[Ventes]
        ([NumVente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- inserts

INSERT INTO pharmaDB.dbo.Familles (Designation) VALUES
	 (N'testf1'),
	 (N'denna');

INSERT INTO pharmaDB.dbo.Users (Login,Password,Name) VALUES
	 (N'admin',N'admin',N'Admin');

INSERT INTO pharmaDB.dbo.Stocks (QuantiteMedicament) VALUES
	 (2),
	 (88);
INSERT INTO pharmaDB.dbo.Medicaments (LibelleMedicament,Prix,CodeFamille) VALUES
	 (N'med1',120.0000,1),
	 (N'med2',100.0000,2);
INSERT INTO pharmaDB.dbo.StockMedis (QuantiteMedicament,NumStock,CodeMedicament) VALUES
	 (2,1,1),
	 (88,2,2);
INSERT INTO pharmaDB.dbo.Ventes (DateVente,MontantVente) VALUES
	 ('2021-11-21 10:51:58.0',240.0000),
	 ('2021-11-22 10:58:42.0',270.0000),
	 ('2021-11-23 16:01:36.363',120.0000),
	 ('2021-11-23 16:08:27.78',360.0000),
	 ('2021-11-23 16:18:43.92',1200.0000);
INSERT INTO pharmaDB.dbo.VenteMedis (QuantiteMedicament,NumVente,CodeMedicament) VALUES
	 (2,1,1),
	 (2,2,1),
	 (1,3,1),
	 (3,4,1),
	 (12,5,2);
-- --------------------------------------------------
-- Script has ended
-- ---------------------------------------------------- --------------------------------------------------