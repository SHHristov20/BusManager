CREATE DATABASE BusManager;
USE BusManager;

CREATE TABLE [UserTypes] (
    [Id] int NOT NULL IDENTITY PRIMARY KEY,
    [Name] nvarchar(max) NOT NULL,
);

INSERT INTO [UserTypes] ([Name])
VALUES (N'User'), 
       (N'Staff'), 
       (N'Admin');

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

INSERT INTO [Users] ([Email], [FirstName], [LastName], [Password], [UserTypeId])
VALUES (N'admin', N'Admin', N'Admin', N'$2a$04$srEq7x2/m/gNjDV1BiOKYuozaHzx8uCiRFto/.y7hW4aUXyAsEKg2', 3),
       (N'staff', N'Staff', N'Staff', N'$2a$04$DDXAkQvGT/HO2wYk6I81uOVNnFxvGFRUrKiwkSj2dVGw7UzBFegHy', 2),
       (N'user', N'User', N'User', N'$2a$04$aTQazmIdabP6cV/VkbeyQuDV.eVX0lwE7x17dF6TmBN38aI3jDO0q', 1);

CREATE TABLE [Cities] (
    [Id] int NOT NULL IDENTITY PRIMARY KEY,
    [Name] nvarchar(max) NOT NULL,
);

INSERT INTO [Cities] ([Name])
VALUES (N'Blagoevgrad'),
       (N'Burgas'),
       (N'Varna'),
       (N'Veliko Tarnovo'),
       (N'Vidin'),
       (N'Vraca'),
       (N'Gabrovo'),
       (N'Dobrich'),
       (N'Kardzali'),
       (N'Kyustendil'),
       (N'Lovech'),
       (N'Montana'),
       (N'Pazardzhik'),
       (N'Pernik'),
       (N'Pleven'),
       (N'Plovdiv'),
       (N'Razgrad'),
       (N'Ruse'),
       (N'Silistra'),
       (N'Sliven'),
       (N'Smolyan'),
       (N'Sofia'),
       (N'Stara Zagora'),
       (N'Targovishte'),
       (N'Haskovo'),
       (N'Shumen'),
       (N'Yambol');

CREATE TABLE [Stations] (
    [Id] int NOT NULL IDENTITY PRIMARY KEY,
    [Name] nvarchar(max) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [CityId] int NOT NULL,
    CONSTRAINT [FK_Stations_Cities_CityId] FOREIGN KEY ([CityId]) REFERENCES [Cities] ([Id]) ON DELETE CASCADE
);

INSERT INTO [Stations] ([Address], [CityId], [Name])
VALUES (N'pl. Tsaritsa Yoanna', 2, N'South Bus Station'),
       (N'Blvd Knyagina Maria Luisa 100', 22, N'Central Bus Station'),
       (N'Blvd Vladislav Varnenchik 158', 3, N'Central Bus Station');

CREATE TABLE [Schedules] (
    [Id] int NOT NULL IDENTITY PRIMARY KEY,
    [Time] datetime2 NOT NULL,
    [Price] real NOT NULL,
    [FromStationId] int NOT NULL,
    [ToStationId] int NOT NULL,
    CONSTRAINT [FK_Schedules_Stations_FromStationId] FOREIGN KEY ([FromStationId]) REFERENCES [Stations] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Schedules_Stations_ToStationId] FOREIGN KEY ([ToStationId]) REFERENCES [Stations] ([Id]) ON DELETE NO ACTION
);

INSERT INTO [Schedules] ([FromStationId], [Price], [Time], [ToStationId])
VALUES (1, 14.00, '2024-01-17T17:30:00.0000000', 3),
       (3, 14.00, '2024-01-17T15:40:00.0000000', 1),
       (1, 30.00, '2024-01-17T18:10:00.0000000', 2),
       (2, 30.00, '2024-01-18T19:10:00.0000000', 1),
       (1, 14.00, '2024-01-18T21:00:00.0000000', 3),
       (3, 14.00, '2024-01-18T17:35:00.0000000', 1),
       (1, 30.00, '2024-01-19T16:50:00.0000000', 2),
       (2, 30.00, '2024-01-19T20:10:00.0000000', 1);

CREATE TABLE [Tickets] (
    [Id] int NOT NULL IDENTITY PRIMARY KEY,
    [Code] nvarchar(max) NOT NULL,
    [BuyerId] int NOT NULL,
    [ScheduleId] int NOT NULL,
    CONSTRAINT [FK_Tickets_Schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [Schedules] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tickets_Users_BuyerId] FOREIGN KEY ([BuyerId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);