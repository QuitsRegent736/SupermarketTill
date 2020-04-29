
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/16/2020 19:49:00
-- Generated from EDMX file: C:\Users\kianw\Documents\OOD 24th April\SupermarketTill\SupermarketTill\Supermarket.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Supermarket];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EverydayItems'
CREATE TABLE [dbo].[EverydayItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OffLicenses'
CREATE TABLE [dbo].[OffLicenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ItemName] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DeliFoods'
CREATE TABLE [dbo].[DeliFoods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FoodItem] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EverydayItems'
ALTER TABLE [dbo].[EverydayItems]
ADD CONSTRAINT [PK_EverydayItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OffLicenses'
ALTER TABLE [dbo].[OffLicenses]
ADD CONSTRAINT [PK_OffLicenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeliFoods'
ALTER TABLE [dbo].[DeliFoods]
ADD CONSTRAINT [PK_DeliFoods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------