
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/23/2018 11:54:15
-- Generated from EDMX file: F:\Bizruntime\prac\mvc-entityframework\EntityModelFirst\ModelFirst\Models\TrainsDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TrainsDb];
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

-- Creating table 'tblTrains'
CREATE TABLE [dbo].[tblTrains] (
    [TrainNo] int IDENTITY(1,1) NOT NULL,
    [TrainName] nvarchar(max)  NOT NULL,
    [Departure] nvarchar(max)  NOT NULL,
    [Destination] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TrainNo] in table 'tblTrains'
ALTER TABLE [dbo].[tblTrains]
ADD CONSTRAINT [PK_tblTrains]
    PRIMARY KEY CLUSTERED ([TrainNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------