
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2013 12:36:06
-- Generated from EDMX file: C:\_Work\Radan\Proiecte\SiriusWLM\EntityModels\EntityModelSirius.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sirius];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientClientLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientLocations] DROP CONSTRAINT [FK_ClientClientLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientInputOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InputOrders] DROP CONSTRAINT [FK_ClientInputOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientLocationClientContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientContacts] DROP CONSTRAINT [FK_ClientLocationClientContact];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientWarehouseRow_Client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientWarehouseRow] DROP CONSTRAINT [FK_ClientWarehouseRow_Client];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientWarehouseRow_WarehouseRow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientWarehouseRow] DROP CONSTRAINT [FK_ClientWarehouseRow_WarehouseRow];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_CompanyUser];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clients] DROP CONSTRAINT [FK_CountryClient];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryClientLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClientLocations] DROP CONSTRAINT [FK_CountryClientLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Companies] DROP CONSTRAINT [FK_CountryCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryWarehouse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Warehouses] DROP CONSTRAINT [FK_CountryWarehouse];
GO
IF OBJECT_ID(N'[dbo].[FK_InputOrderInputOrderProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InputOrderProducts] DROP CONSTRAINT [FK_InputOrderInputOrderProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_InputOrderInputReception]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InputReceptions] DROP CONSTRAINT [FK_InputOrderInputReception];
GO
IF OBJECT_ID(N'[dbo].[FK_InputReceptionPackage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Packages] DROP CONSTRAINT [FK_InputReceptionPackage];
GO
IF OBJECT_ID(N'[dbo].[FK_PackageTransferDestination]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfers] DROP CONSTRAINT [FK_PackageTransferDestination];
GO
IF OBJECT_ID(N'[dbo].[FK_PackageTransferSource]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfers] DROP CONSTRAINT [FK_PackageTransferSource];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_Client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Product_Client];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_MeasuringUnit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Product_MeasuringUnit];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductBatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Packages] DROP CONSTRAINT [FK_ProductBatch];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductInputOrderProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InputOrderProducts] DROP CONSTRAINT [FK_ProductInputOrderProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_UserLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Logs] DROP CONSTRAINT [FK_UserLog];
GO
IF OBJECT_ID(N'[dbo].[FK_Warehouse_Company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Warehouses] DROP CONSTRAINT [FK_Warehouse_Company];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseContainer_WarehouseRow]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WarehouseContainers] DROP CONSTRAINT [FK_WarehouseContainer_WarehouseRow];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseContainerPackage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Packages] DROP CONSTRAINT [FK_WarehouseContainerPackage];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseContainerTransferDestination]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfers] DROP CONSTRAINT [FK_WarehouseContainerTransferDestination];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseContainerTransferSource]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transfers] DROP CONSTRAINT [FK_WarehouseContainerTransferSource];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseRoom_Warehouse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WarehouseRooms] DROP CONSTRAINT [FK_WarehouseRoom_Warehouse];
GO
IF OBJECT_ID(N'[dbo].[FK_WarehouseRow_WarehouseRoom]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WarehouseRows] DROP CONSTRAINT [FK_WarehouseRow_WarehouseRoom];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClientContacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientContacts];
GO
IF OBJECT_ID(N'[dbo].[ClientLocations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientLocations];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[ClientWarehouseRow]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientWarehouseRow];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[InputOrderProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InputOrderProducts];
GO
IF OBJECT_ID(N'[dbo].[InputOrders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InputOrders];
GO
IF OBJECT_ID(N'[dbo].[InputReceptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InputReceptions];
GO
IF OBJECT_ID(N'[dbo].[Logs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logs];
GO
IF OBJECT_ID(N'[dbo].[MeasuringUnits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeasuringUnits];
GO
IF OBJECT_ID(N'[dbo].[Packages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Packages];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Transfers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transfers];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Versionings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Versionings];
GO
IF OBJECT_ID(N'[dbo].[WarehouseContainers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WarehouseContainers];
GO
IF OBJECT_ID(N'[dbo].[WarehouseRooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WarehouseRooms];
GO
IF OBJECT_ID(N'[dbo].[WarehouseRows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WarehouseRows];
GO
IF OBJECT_ID(N'[dbo].[Warehouses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Warehouses];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClientContacts'
CREATE TABLE [dbo].[ClientContacts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Email] nvarchar(50)  NULL,
    [Phone1] nvarchar(50)  NULL,
    [Phone2] nvarchar(50)  NULL,
    [Position] nvarchar(50)  NULL,
    [ClientLocation_Id] int  NOT NULL
);
GO

-- Creating table 'ClientLocations'
CREATE TABLE [dbo].[ClientLocations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Address] nvarchar(100)  NULL,
    [Client_Id] int  NOT NULL,
    [Country_Id] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameLong] nvarchar(50)  NOT NULL,
    [NameShort] nvarchar(50)  NOT NULL,
    [Country_Id] int  NOT NULL,
    [Company_Id] int  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameLong] nvarchar(50)  NOT NULL,
    [NameShort] nvarchar(50)  NOT NULL,
    [Country_Id] int  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InputOrderProducts'
CREATE TABLE [dbo].[InputOrderProducts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] float  NOT NULL,
    [InputOrder_Id] int  NOT NULL,
    [Product_Id] int  NOT NULL
);
GO

-- Creating table 'InputOrders'
CREATE TABLE [dbo].[InputOrders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientDocumentName] nvarchar(max)  NULL,
    [ClientDocumentDate] datetime  NULL,
    [DateCreation] datetime  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'InputReceptions'
CREATE TABLE [dbo].[InputReceptions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DateCreation] datetime  NOT NULL,
    [InputOrder_Id] int  NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsError] bit  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateCreation] datetime  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'MeasuringUnits'
CREATE TABLE [dbo].[MeasuringUnits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Packages'
CREATE TABLE [dbo].[Packages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Batch] nvarchar(max)  NULL,
    [DateProduction] datetime  NULL,
    [DateExpiration] datetime  NULL,
    [ShelfLife] int  NOT NULL,
    [QuantityInitial] float  NOT NULL,
    [QuantityCurrent] float  NOT NULL,
    [DateCreation] datetime  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [InputReception_Id] int  NOT NULL,
    [Product_Id] int  NOT NULL,
    [WarehouseContainer_Id] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] varchar(50)  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [ConversionFactorKg] float  NOT NULL,
    [Client_Id] int  NOT NULL,
    [MeasuringUnit_Id] int  NOT NULL
);
GO

-- Creating table 'Transfers'
CREATE TABLE [dbo].[Transfers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] float  NOT NULL,
    [DateCreation] datetime  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Description] nvarchar(100)  NULL,
    [DateCreation] datetime  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Versionings'
CREATE TABLE [dbo].[Versionings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Revision] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'WarehouseContainers'
CREATE TABLE [dbo].[WarehouseContainers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(12)  NOT NULL,
    [IsAvailable] bit  NOT NULL,
    [WarehouseRow_Id] int  NOT NULL
);
GO

-- Creating table 'WarehouseRooms'
CREATE TABLE [dbo].[WarehouseRooms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Number] int  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Warehouse_Id] int  NOT NULL
);
GO

-- Creating table 'WarehouseRows'
CREATE TABLE [dbo].[WarehouseRows] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Number] int  NOT NULL,
    [Description] nvarchar(50)  NULL,
    [WarehouseRoom_Id] int  NOT NULL
);
GO

-- Creating table 'Warehouses'
CREATE TABLE [dbo].[Warehouses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [Company_Id] int  NOT NULL,
    [Country_Id] int  NOT NULL
);
GO

-- Creating table 'ClientUsers'
CREATE TABLE [dbo].[ClientUsers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Description] nvarchar(100)  NULL,
    [DateCreation] datetime  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Client_Id] int  NOT NULL
);
GO

-- Creating table 'ClientLogs'
CREATE TABLE [dbo].[ClientLogs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsError] bit  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateCreation] datetime  NOT NULL,
    [ClientUser_Id] int  NOT NULL
);
GO

-- Creating table 'ClientWarehouseRow'
CREATE TABLE [dbo].[ClientWarehouseRow] (
    [Clients_Id] int  NOT NULL,
    [WarehouseRows_Id] int  NOT NULL
);
GO

-- Creating table 'CompanyUser'
CREATE TABLE [dbo].[CompanyUser] (
    [Companies_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClientContacts'
ALTER TABLE [dbo].[ClientContacts]
ADD CONSTRAINT [PK_ClientContacts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientLocations'
ALTER TABLE [dbo].[ClientLocations]
ADD CONSTRAINT [PK_ClientLocations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InputOrderProducts'
ALTER TABLE [dbo].[InputOrderProducts]
ADD CONSTRAINT [PK_InputOrderProducts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InputOrders'
ALTER TABLE [dbo].[InputOrders]
ADD CONSTRAINT [PK_InputOrders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InputReceptions'
ALTER TABLE [dbo].[InputReceptions]
ADD CONSTRAINT [PK_InputReceptions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MeasuringUnits'
ALTER TABLE [dbo].[MeasuringUnits]
ADD CONSTRAINT [PK_MeasuringUnits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Packages'
ALTER TABLE [dbo].[Packages]
ADD CONSTRAINT [PK_Packages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transfers'
ALTER TABLE [dbo].[Transfers]
ADD CONSTRAINT [PK_Transfers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Versionings'
ALTER TABLE [dbo].[Versionings]
ADD CONSTRAINT [PK_Versionings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WarehouseContainers'
ALTER TABLE [dbo].[WarehouseContainers]
ADD CONSTRAINT [PK_WarehouseContainers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WarehouseRooms'
ALTER TABLE [dbo].[WarehouseRooms]
ADD CONSTRAINT [PK_WarehouseRooms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WarehouseRows'
ALTER TABLE [dbo].[WarehouseRows]
ADD CONSTRAINT [PK_WarehouseRows]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Warehouses'
ALTER TABLE [dbo].[Warehouses]
ADD CONSTRAINT [PK_Warehouses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientUsers'
ALTER TABLE [dbo].[ClientUsers]
ADD CONSTRAINT [PK_ClientUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientLogs'
ALTER TABLE [dbo].[ClientLogs]
ADD CONSTRAINT [PK_ClientLogs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Clients_Id], [WarehouseRows_Id] in table 'ClientWarehouseRow'
ALTER TABLE [dbo].[ClientWarehouseRow]
ADD CONSTRAINT [PK_ClientWarehouseRow]
    PRIMARY KEY NONCLUSTERED ([Clients_Id], [WarehouseRows_Id] ASC);
GO

-- Creating primary key on [Companies_Id], [Users_Id] in table 'CompanyUser'
ALTER TABLE [dbo].[CompanyUser]
ADD CONSTRAINT [PK_CompanyUser]
    PRIMARY KEY NONCLUSTERED ([Companies_Id], [Users_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClientLocation_Id] in table 'ClientContacts'
ALTER TABLE [dbo].[ClientContacts]
ADD CONSTRAINT [FK_ClientLocationClientContact]
    FOREIGN KEY ([ClientLocation_Id])
    REFERENCES [dbo].[ClientLocations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientLocationClientContact'
CREATE INDEX [IX_FK_ClientLocationClientContact]
ON [dbo].[ClientContacts]
    ([ClientLocation_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientLocations'
ALTER TABLE [dbo].[ClientLocations]
ADD CONSTRAINT [FK_ClientClientLocation]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientClientLocation'
CREATE INDEX [IX_FK_ClientClientLocation]
ON [dbo].[ClientLocations]
    ([Client_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'ClientLocations'
ALTER TABLE [dbo].[ClientLocations]
ADD CONSTRAINT [FK_CountryClientLocation]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryClientLocation'
CREATE INDEX [IX_FK_CountryClientLocation]
ON [dbo].[ClientLocations]
    ([Country_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'InputOrders'
ALTER TABLE [dbo].[InputOrders]
ADD CONSTRAINT [FK_ClientInputOrder]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientInputOrder'
CREATE INDEX [IX_FK_ClientInputOrder]
ON [dbo].[InputOrders]
    ([Client_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [FK_CountryClient]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryClient'
CREATE INDEX [IX_FK_CountryClient]
ON [dbo].[Clients]
    ([Country_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_Client]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_Client'
CREATE INDEX [IX_FK_Product_Client]
ON [dbo].[Products]
    ([Client_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [FK_CountryCompany]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryCompany'
CREATE INDEX [IX_FK_CountryCompany]
ON [dbo].[Companies]
    ([Country_Id]);
GO

-- Creating foreign key on [Company_Id] in table 'Warehouses'
ALTER TABLE [dbo].[Warehouses]
ADD CONSTRAINT [FK_Warehouse_Company]
    FOREIGN KEY ([Company_Id])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Warehouse_Company'
CREATE INDEX [IX_FK_Warehouse_Company]
ON [dbo].[Warehouses]
    ([Company_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'Warehouses'
ALTER TABLE [dbo].[Warehouses]
ADD CONSTRAINT [FK_CountryWarehouse]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryWarehouse'
CREATE INDEX [IX_FK_CountryWarehouse]
ON [dbo].[Warehouses]
    ([Country_Id]);
GO

-- Creating foreign key on [InputOrder_Id] in table 'InputOrderProducts'
ALTER TABLE [dbo].[InputOrderProducts]
ADD CONSTRAINT [FK_InputOrderInputOrderProduct]
    FOREIGN KEY ([InputOrder_Id])
    REFERENCES [dbo].[InputOrders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InputOrderInputOrderProduct'
CREATE INDEX [IX_FK_InputOrderInputOrderProduct]
ON [dbo].[InputOrderProducts]
    ([InputOrder_Id]);
GO

-- Creating foreign key on [Product_Id] in table 'InputOrderProducts'
ALTER TABLE [dbo].[InputOrderProducts]
ADD CONSTRAINT [FK_ProductInputOrderProduct]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductInputOrderProduct'
CREATE INDEX [IX_FK_ProductInputOrderProduct]
ON [dbo].[InputOrderProducts]
    ([Product_Id]);
GO

-- Creating foreign key on [InputOrder_Id] in table 'InputReceptions'
ALTER TABLE [dbo].[InputReceptions]
ADD CONSTRAINT [FK_InputOrderInputReception]
    FOREIGN KEY ([InputOrder_Id])
    REFERENCES [dbo].[InputOrders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InputOrderInputReception'
CREATE INDEX [IX_FK_InputOrderInputReception]
ON [dbo].[InputReceptions]
    ([InputOrder_Id]);
GO

-- Creating foreign key on [InputReception_Id] in table 'Packages'
ALTER TABLE [dbo].[Packages]
ADD CONSTRAINT [FK_InputReceptionPackage]
    FOREIGN KEY ([InputReception_Id])
    REFERENCES [dbo].[InputReceptions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_InputReceptionPackage'
CREATE INDEX [IX_FK_InputReceptionPackage]
ON [dbo].[Packages]
    ([InputReception_Id]);
GO

-- Creating foreign key on [User_Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [FK_UserLog]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserLog'
CREATE INDEX [IX_FK_UserLog]
ON [dbo].[Logs]
    ([User_Id]);
GO

-- Creating foreign key on [MeasuringUnit_Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Product_MeasuringUnit]
    FOREIGN KEY ([MeasuringUnit_Id])
    REFERENCES [dbo].[MeasuringUnits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_MeasuringUnit'
CREATE INDEX [IX_FK_Product_MeasuringUnit]
ON [dbo].[Products]
    ([MeasuringUnit_Id]);
GO

-- Creating foreign key on [Product_Id] in table 'Packages'
ALTER TABLE [dbo].[Packages]
ADD CONSTRAINT [FK_ProductBatch]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductBatch'
CREATE INDEX [IX_FK_ProductBatch]
ON [dbo].[Packages]
    ([Product_Id]);
GO

-- Creating foreign key on [WarehouseContainer_Id] in table 'Packages'
ALTER TABLE [dbo].[Packages]
ADD CONSTRAINT [FK_WarehouseContainerPackage]
    FOREIGN KEY ([WarehouseContainer_Id])
    REFERENCES [dbo].[WarehouseContainers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WarehouseContainerPackage'
CREATE INDEX [IX_FK_WarehouseContainerPackage]
ON [dbo].[Packages]
    ([WarehouseContainer_Id]);
GO

-- Creating foreign key on [WarehouseRow_Id] in table 'WarehouseContainers'
ALTER TABLE [dbo].[WarehouseContainers]
ADD CONSTRAINT [FK_WarehouseContainer_WarehouseRow]
    FOREIGN KEY ([WarehouseRow_Id])
    REFERENCES [dbo].[WarehouseRows]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WarehouseContainer_WarehouseRow'
CREATE INDEX [IX_FK_WarehouseContainer_WarehouseRow]
ON [dbo].[WarehouseContainers]
    ([WarehouseRow_Id]);
GO

-- Creating foreign key on [Warehouse_Id] in table 'WarehouseRooms'
ALTER TABLE [dbo].[WarehouseRooms]
ADD CONSTRAINT [FK_WarehouseRoom_Warehouse]
    FOREIGN KEY ([Warehouse_Id])
    REFERENCES [dbo].[Warehouses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WarehouseRoom_Warehouse'
CREATE INDEX [IX_FK_WarehouseRoom_Warehouse]
ON [dbo].[WarehouseRooms]
    ([Warehouse_Id]);
GO

-- Creating foreign key on [WarehouseRoom_Id] in table 'WarehouseRows'
ALTER TABLE [dbo].[WarehouseRows]
ADD CONSTRAINT [FK_WarehouseRow_WarehouseRoom]
    FOREIGN KEY ([WarehouseRoom_Id])
    REFERENCES [dbo].[WarehouseRooms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WarehouseRow_WarehouseRoom'
CREATE INDEX [IX_FK_WarehouseRow_WarehouseRoom]
ON [dbo].[WarehouseRows]
    ([WarehouseRoom_Id]);
GO

-- Creating foreign key on [Clients_Id] in table 'ClientWarehouseRow'
ALTER TABLE [dbo].[ClientWarehouseRow]
ADD CONSTRAINT [FK_ClientWarehouseRow_Client]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [WarehouseRows_Id] in table 'ClientWarehouseRow'
ALTER TABLE [dbo].[ClientWarehouseRow]
ADD CONSTRAINT [FK_ClientWarehouseRow_WarehouseRow]
    FOREIGN KEY ([WarehouseRows_Id])
    REFERENCES [dbo].[WarehouseRows]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientWarehouseRow_WarehouseRow'
CREATE INDEX [IX_FK_ClientWarehouseRow_WarehouseRow]
ON [dbo].[ClientWarehouseRow]
    ([WarehouseRows_Id]);
GO

-- Creating foreign key on [Company_Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [FK_CompanyClient]
    FOREIGN KEY ([Company_Id])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyClient'
CREATE INDEX [IX_FK_CompanyClient]
ON [dbo].[Clients]
    ([Company_Id]);
GO

-- Creating foreign key on [Companies_Id] in table 'CompanyUser'
ALTER TABLE [dbo].[CompanyUser]
ADD CONSTRAINT [FK_CompanyUser_Company]
    FOREIGN KEY ([Companies_Id])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'CompanyUser'
ALTER TABLE [dbo].[CompanyUser]
ADD CONSTRAINT [FK_CompanyUser_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyUser_User'
CREATE INDEX [IX_FK_CompanyUser_User]
ON [dbo].[CompanyUser]
    ([Users_Id]);
GO

-- Creating foreign key on [Client_Id] in table 'ClientUsers'
ALTER TABLE [dbo].[ClientUsers]
ADD CONSTRAINT [FK_ClientClientUser]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientClientUser'
CREATE INDEX [IX_FK_ClientClientUser]
ON [dbo].[ClientUsers]
    ([Client_Id]);
GO

-- Creating foreign key on [ClientUser_Id] in table 'ClientLogs'
ALTER TABLE [dbo].[ClientLogs]
ADD CONSTRAINT [FK_ClientUserClientLog]
    FOREIGN KEY ([ClientUser_Id])
    REFERENCES [dbo].[ClientUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientUserClientLog'
CREATE INDEX [IX_FK_ClientUserClientLog]
ON [dbo].[ClientLogs]
    ([ClientUser_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------