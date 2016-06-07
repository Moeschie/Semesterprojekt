
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2016 17:49:53
-- Generated from EDMX file: C:\Users\mschl\Source\Repos\Semesterprojekt\Auftragsmanager\Repository\Models\DataContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBAuftragsmanager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_ContactPerson_dbo_Adress_adress_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContactPerson] DROP CONSTRAINT [FK_dbo_ContactPerson_dbo_Adress_adress_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Machine_dbo_EdvActions_EdvActions_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Machine] DROP CONSTRAINT [FK_dbo_Machine_dbo_EdvActions_EdvActions_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_MachineTask_dbo_Machine_machine_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MachineTask] DROP CONSTRAINT [FK_dbo_MachineTask_dbo_Machine_machine_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Order_dbo_EdvActions_EdvActions_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_dbo_Order_dbo_EdvActions_EdvActions_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Order_dbo_OrderDetails_Details_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_dbo_Order_dbo_OrderDetails_Details_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Order_dbo_ProductionActions_ProductionActions_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_dbo_Order_dbo_ProductionActions_ProductionActions_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_OrderDetails_dbo_Adress_RemainsToo_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_dbo_OrderDetails_dbo_Adress_RemainsToo_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_OrderDetails_dbo_Customer_Customer_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_dbo_OrderDetails_dbo_Customer_Customer_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_OrderDetails_dbo_User_Editor_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_dbo_OrderDetails_dbo_User_Editor_Id];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Adress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Adress];
GO
IF OBJECT_ID(N'[dbo].[ContactPerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContactPerson];
GO
IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[CustomerObject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerObject];
GO
IF OBJECT_ID(N'[dbo].[EdvActions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EdvActions];
GO
IF OBJECT_ID(N'[dbo].[Machine]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Machine];
GO
IF OBJECT_ID(N'[dbo].[MachineTask]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MachineTask];
GO
IF OBJECT_ID(N'[dbo].[Order]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Order];
GO
IF OBJECT_ID(N'[dbo].[OrderDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderDetails];
GO
IF OBJECT_ID(N'[dbo].[ProductionActions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductionActions];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Adress'
CREATE TABLE [dbo].[Adress] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Street] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [Country] nvarchar(max)  NULL,
    [POBox] nvarchar(max)  NULL,
    [ZIP] nvarchar(max)  NULL
);
GO

-- Creating table 'ContactPerson'
CREATE TABLE [dbo].[ContactPerson] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Telefon] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Mail] nvarchar(max)  NULL,
    [adress_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'Customer'
CREATE TABLE [dbo].[Customer] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NULL
);
GO

-- Creating table 'CustomerObject'
CREATE TABLE [dbo].[CustomerObject] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NULL
);
GO

-- Creating table 'EdvActions'
CREATE TABLE [dbo].[EdvActions] (
    [Id] uniqueidentifier  NOT NULL,
    [Actions] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Machine'
CREATE TABLE [dbo].[Machine] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [EdvActions_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'MachineTask'
CREATE TABLE [dbo].[MachineTask] (
    [Id] uniqueidentifier  NOT NULL,
    [UsageStart] nvarchar(max)  NULL,
    [UsageEnd] nvarchar(max)  NULL,
    [title] nvarchar(max)  NULL,
    [type] nvarchar(max)  NULL,
    [machine_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'Order'
CREATE TABLE [dbo].[Order] (
    [Id] uniqueidentifier  NOT NULL,
    [Details_Id] uniqueidentifier  NULL,
    [EdvActions_Id] uniqueidentifier  NULL,
    [ProductionActions_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [Id] uniqueidentifier  NOT NULL,
    [Object] nvarchar(max)  NULL,
    [OverallQuantity] int  NOT NULL,
    [Foreign] nvarchar(max)  NULL,
    [SplitForeinLand] nvarchar(max)  NULL,
    [SplitHomeLand] nvarchar(max)  NULL,
    [AdditionalInformation] nvarchar(max)  NULL,
    [BillTo] nvarchar(max)  NULL,
    [Material] nvarchar(max)  NULL,
    [IncomeDate] nvarchar(max)  NULL,
    [IncomeTime] nvarchar(max)  NULL,
    [Deadline] nvarchar(max)  NULL,
    [OrderEdition] nvarchar(max)  NULL,
    [OrderName] nvarchar(max)  NULL,
    [OrderNumber] nvarchar(max)  NULL,
    [Customer_Id] uniqueidentifier  NULL,
    [Editor_Id] uniqueidentifier  NULL,
    [RemainsToo_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'ProductionActions'
CREATE TABLE [dbo].[ProductionActions] (
    [Id] uniqueidentifier  NOT NULL,
    [Insert] nvarchar(max)  NULL,
    [InsertKind] nvarchar(max)  NULL,
    [Kuvert] bit  NOT NULL,
    [Ink] bit  NOT NULL,
    [folieren] bit  NOT NULL,
    [value] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [Username] nvarchar(max)  NULL,
    [AccessLevel] int  NOT NULL,
    [Password] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Adress'
ALTER TABLE [dbo].[Adress]
ADD CONSTRAINT [PK_Adress]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContactPerson'
ALTER TABLE [dbo].[ContactPerson]
ADD CONSTRAINT [PK_ContactPerson]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [PK_Customer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerObject'
ALTER TABLE [dbo].[CustomerObject]
ADD CONSTRAINT [PK_CustomerObject]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EdvActions'
ALTER TABLE [dbo].[EdvActions]
ADD CONSTRAINT [PK_EdvActions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Machine'
ALTER TABLE [dbo].[Machine]
ADD CONSTRAINT [PK_Machine]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MachineTask'
ALTER TABLE [dbo].[MachineTask]
ADD CONSTRAINT [PK_MachineTask]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [PK_Order]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductionActions'
ALTER TABLE [dbo].[ProductionActions]
ADD CONSTRAINT [PK_ProductionActions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [adress_Id] in table 'ContactPerson'
ALTER TABLE [dbo].[ContactPerson]
ADD CONSTRAINT [FK_dbo_ContactPerson_dbo_Adress_adress_Id]
    FOREIGN KEY ([adress_Id])
    REFERENCES [dbo].[Adress]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ContactPerson_dbo_Adress_adress_Id'
CREATE INDEX [IX_FK_dbo_ContactPerson_dbo_Adress_adress_Id]
ON [dbo].[ContactPerson]
    ([adress_Id]);
GO

-- Creating foreign key on [RemainsToo_Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_dbo_OrderDetails_dbo_Adress_RemainsToo_Id]
    FOREIGN KEY ([RemainsToo_Id])
    REFERENCES [dbo].[Adress]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_OrderDetails_dbo_Adress_RemainsToo_Id'
CREATE INDEX [IX_FK_dbo_OrderDetails_dbo_Adress_RemainsToo_Id]
ON [dbo].[OrderDetails]
    ([RemainsToo_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_dbo_OrderDetails_dbo_Customer_Customer_Id]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_OrderDetails_dbo_Customer_Customer_Id'
CREATE INDEX [IX_FK_dbo_OrderDetails_dbo_Customer_Customer_Id]
ON [dbo].[OrderDetails]
    ([Customer_Id]);
GO

-- Creating foreign key on [EdvActions_Id] in table 'Machine'
ALTER TABLE [dbo].[Machine]
ADD CONSTRAINT [FK_dbo_Machine_dbo_EdvActions_EdvActions_Id]
    FOREIGN KEY ([EdvActions_Id])
    REFERENCES [dbo].[EdvActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Machine_dbo_EdvActions_EdvActions_Id'
CREATE INDEX [IX_FK_dbo_Machine_dbo_EdvActions_EdvActions_Id]
ON [dbo].[Machine]
    ([EdvActions_Id]);
GO

-- Creating foreign key on [EdvActions_Id] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [FK_dbo_Order_dbo_EdvActions_EdvActions_Id]
    FOREIGN KEY ([EdvActions_Id])
    REFERENCES [dbo].[EdvActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Order_dbo_EdvActions_EdvActions_Id'
CREATE INDEX [IX_FK_dbo_Order_dbo_EdvActions_EdvActions_Id]
ON [dbo].[Order]
    ([EdvActions_Id]);
GO

-- Creating foreign key on [machine_Id] in table 'MachineTask'
ALTER TABLE [dbo].[MachineTask]
ADD CONSTRAINT [FK_dbo_MachineTask_dbo_Machine_machine_Id]
    FOREIGN KEY ([machine_Id])
    REFERENCES [dbo].[Machine]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_MachineTask_dbo_Machine_machine_Id'
CREATE INDEX [IX_FK_dbo_MachineTask_dbo_Machine_machine_Id]
ON [dbo].[MachineTask]
    ([machine_Id]);
GO

-- Creating foreign key on [Details_Id] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [FK_dbo_Order_dbo_OrderDetails_Details_Id]
    FOREIGN KEY ([Details_Id])
    REFERENCES [dbo].[OrderDetails]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Order_dbo_OrderDetails_Details_Id'
CREATE INDEX [IX_FK_dbo_Order_dbo_OrderDetails_Details_Id]
ON [dbo].[Order]
    ([Details_Id]);
GO

-- Creating foreign key on [ProductionActions_Id] in table 'Order'
ALTER TABLE [dbo].[Order]
ADD CONSTRAINT [FK_dbo_Order_dbo_ProductionActions_ProductionActions_Id]
    FOREIGN KEY ([ProductionActions_Id])
    REFERENCES [dbo].[ProductionActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Order_dbo_ProductionActions_ProductionActions_Id'
CREATE INDEX [IX_FK_dbo_Order_dbo_ProductionActions_ProductionActions_Id]
ON [dbo].[Order]
    ([ProductionActions_Id]);
GO

-- Creating foreign key on [Editor_Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_dbo_OrderDetails_dbo_User_Editor_Id]
    FOREIGN KEY ([Editor_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_OrderDetails_dbo_User_Editor_Id'
CREATE INDEX [IX_FK_dbo_OrderDetails_dbo_User_Editor_Id]
ON [dbo].[OrderDetails]
    ([Editor_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------