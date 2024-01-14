CREATE DATABASE BusManager;
USE DATABASE BusManager;
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [UserTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_UserTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [UserTypeId] int NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Users_UserTypes_UserTypeId] FOREIGN KEY ([UserTypeId]) REFERENCES [UserTypes] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[UserTypes]'))
    SET IDENTITY_INSERT [UserTypes] ON;
INSERT INTO [UserTypes] ([Id], [Name])
VALUES (1, N'User'),
(2, N'Driver'),
(3, N'Staff'),
(4, N'Manager'),
(5, N'Admin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[UserTypes]'))
    SET IDENTITY_INSERT [UserTypes] OFF;
GO

CREATE INDEX [IX_Users_UserTypeId] ON [Users] ([UserTypeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240107173203_InitialCreate', N'8.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Cities] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Cities] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Stations] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [CityId] int NOT NULL,
    CONSTRAINT [PK_Stations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Stations_Cities_CityId] FOREIGN KEY ([CityId]) REFERENCES [Cities] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Cities]'))
    SET IDENTITY_INSERT [Cities] ON;
INSERT INTO [Cities] ([Id], [Name])
VALUES (1, N'Blagoevgrad'),
(2, N'Burgas'),
(3, N'Varna'),
(4, N'Veliko Tarnovo'),
(5, N'Vidin'),
(6, N'Vraca'),
(7, N'Gabrovo'),
(8, N'Dobrich'),
(9, N'Kardzali'),
(10, N'Kyustendil'),
(11, N'Lovech'),
(12, N'Montana'),
(13, N'Pazardzhik'),
(14, N'Pernik'),
(15, N'Pleven'),
(16, N'Plovdiv'),
(17, N'Razgrad'),
(18, N'Ruse'),
(19, N'Silistra'),
(20, N'Sliven'),
(21, N'Smolyan'),
(22, N'Sofia'),
(23, N'Stara Zagora'),
(24, N'Targovishte'),
(25, N'Haskovo'),
(26, N'Shumen'),
(27, N'Yambol');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Cities]'))
    SET IDENTITY_INSERT [Cities] OFF;
GO

CREATE INDEX [IX_Stations_CityId] ON [Stations] ([CityId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240108201939_CreateStations', N'8.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [UserTypes]
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

DELETE FROM [UserTypes]
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

CREATE TABLE [Schedules] (
    [Id] int NOT NULL IDENTITY,
    [Time] datetime2 NOT NULL,
    [Price] real NOT NULL,
    [FromStationId] int NOT NULL,
    [ToStationId] int NOT NULL,
    CONSTRAINT [PK_Schedules] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Schedules_Stations_FromStationId] FOREIGN KEY ([FromStationId]) REFERENCES [Stations] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Schedules_Stations_ToStationId] FOREIGN KEY ([ToStationId]) REFERENCES [Stations] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Tickets] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(max) NOT NULL,
    [BuyerId] int NOT NULL,
    [ScheduleId] int NOT NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tickets_Schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [Schedules] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tickets_Users_BuyerId] FOREIGN KEY ([BuyerId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);
GO

UPDATE [UserTypes] SET [Name] = N'Staff'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [UserTypes] SET [Name] = N'Admin'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_Schedules_FromStationId] ON [Schedules] ([FromStationId]);
GO

CREATE INDEX [IX_Schedules_ToStationId] ON [Schedules] ([ToStationId]);
GO

CREATE INDEX [IX_Tickets_BuyerId] ON [Tickets] ([BuyerId]);
GO

CREATE INDEX [IX_Tickets_ScheduleId] ON [Tickets] ([ScheduleId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240111213310_AddTicketsAndSchedulesTables', N'8.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'CityId', N'Name') AND [object_id] = OBJECT_ID(N'[Stations]'))
    SET IDENTITY_INSERT [Stations] ON;
INSERT INTO [Stations] ([Id], [Address], [CityId], [Name])
VALUES (1, N'pl. Tsaritsa Yoanna', 2, N'South Bus Station'),
(2, N'Blvd Knyagina Maria Luisa 100', 22, N'Central Bus Station'),
(3, N'Blvd Vladislav Varnenchik 158', 3, N'Central Bus Station');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'CityId', N'Name') AND [object_id] = OBJECT_ID(N'[Stations]'))
    SET IDENTITY_INSERT [Stations] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Email', N'FirstName', N'LastName', N'Password', N'UserTypeId') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [Email], [FirstName], [LastName], [Password], [UserTypeId])
VALUES (1, N'admin', N'Admin', N'Admin', N'$2a$04$srEq7x2/m/gNjDV1BiOKYuozaHzx8uCiRFto/.y7hW4aUXyAsEKg2', 3),
(2, N'staff', N'Staff', N'Staff', N'$2a$04$DDXAkQvGT/HO2wYk6I81uOVNnFxvGFRUrKiwkSj2dVGw7UzBFegHy', 2),
(3, N'user', N'User', N'User', N'$2a$04$aTQazmIdabP6cV/VkbeyQuDV.eVX0lwE7x17dF6TmBN38aI3jDO0q', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Email', N'FirstName', N'LastName', N'Password', N'UserTypeId') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FromStationId', N'Price', N'Time', N'ToStationId') AND [object_id] = OBJECT_ID(N'[Schedules]'))
    SET IDENTITY_INSERT [Schedules] ON;
INSERT INTO [Schedules] ([Id], [FromStationId], [Price], [Time], [ToStationId])
VALUES (1, 1, CAST(14 AS real), '2024-01-17T17:30:00.0000000', 3),
(2, 3, CAST(14 AS real), '2024-01-17T15:40:00.0000000', 1),
(3, 1, CAST(30 AS real), '2024-01-17T18:10:00.0000000', 2),
(4, 2, CAST(30 AS real), '2024-01-18T19:10:00.0000000', 1),
(5, 1, CAST(14 AS real), '2024-01-18T21:00:00.0000000', 3),
(6, 3, CAST(14 AS real), '2024-01-18T17:35:00.0000000', 1),
(7, 1, CAST(30 AS real), '2024-01-19T16:50:00.0000000', 2),
(8, 2, CAST(30 AS real), '2024-01-19T20:10:00.0000000', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'FromStationId', N'Price', N'Time', N'ToStationId') AND [object_id] = OBJECT_ID(N'[Schedules]'))
    SET IDENTITY_INSERT [Schedules] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240114175520_AddSeedData', N'8.0.0');
GO

COMMIT;
GO

