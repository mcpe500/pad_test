
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/04/2024 16:43:32
-- Generated from EDMX file: D:\Semester3\PV\PROYEK_BARU\ROTIKITA\ROTIKITA\ROTIKITA\db_roti.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db_roti];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FKBUANG_JENIS_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[buang] DROP CONSTRAINT [FK_FKBUANG_JENIS_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_FKBUANG_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[buang] DROP CONSTRAINT [FK_FKBUANG_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_FKBUNDLE_BUNDLE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dbundle] DROP CONSTRAINT [FK_FKBUNDLE_BUNDLE];
GO
IF OBJECT_ID(N'[dbo].[FK_FKDISKON_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[diskon] DROP CONSTRAINT [FK_FKDISKON_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_FKHTRANS_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dtrans] DROP CONSTRAINT [FK_FKHTRANS_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_FKJENIS_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[roti] DROP CONSTRAINT [FK_FKJENIS_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_FKKODE_ROTI_HTRANS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dtrans] DROP CONSTRAINT [FK_FKKODE_ROTI_HTRANS];
GO
IF OBJECT_ID(N'[dbo].[FK_FKPRODUCT_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[dbundle] DROP CONSTRAINT [FK_FKPRODUCT_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_FKUSER_ROTI]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[htrans] DROP CONSTRAINT [FK_FKUSER_ROTI];
GO
IF OBJECT_ID(N'[dbo].[FK_HTRANS_TRANSDISKON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[transDiskon] DROP CONSTRAINT [FK_HTRANS_TRANSDISKON];
GO
IF OBJECT_ID(N'[dbo].[FK_DISKON_TRANSDISKON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[transDiskon] DROP CONSTRAINT [FK_DISKON_TRANSDISKON];
GO
IF OBJECT_ID(N'[dbo].[FK_BUNDLE_TRANSDISKON]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[transDiskon] DROP CONSTRAINT [FK_BUNDLE_TRANSDISKON];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[buang]', 'U') IS NOT NULL
    DROP TABLE [dbo].[buang];
GO
IF OBJECT_ID(N'[dbo].[dbundle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dbundle];
GO
IF OBJECT_ID(N'[dbo].[diskon]', 'U') IS NOT NULL
    DROP TABLE [dbo].[diskon];
GO
IF OBJECT_ID(N'[dbo].[dtrans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dtrans];
GO
IF OBJECT_ID(N'[dbo].[hbundle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hbundle];
GO
IF OBJECT_ID(N'[dbo].[htrans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[htrans];
GO
IF OBJECT_ID(N'[dbo].[jenis_roti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[jenis_roti];
GO
IF OBJECT_ID(N'[dbo].[roti]', 'U') IS NOT NULL
    DROP TABLE [dbo].[roti];
GO
IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'buangs'
CREATE TABLE [dbo].[buangs] (
    [kode_buang] varchar(10)  NOT NULL,
    [kode_roti] varchar(10)  NULL,
    [kode_jenis] varchar(10)  NULL,
    [nama_roti] varchar(200)  NULL,
    [harga] int  NULL,
    [qty] int  NULL,
    [subtotal] int  NULL,
    [created_at] date  NULL,
    [expired_at] date  NULL,
    [dibuang_at] date  NULL
);
GO

-- Creating table 'dbundles'
CREATE TABLE [dbo].[dbundles] (
    [kode_dbundle] varchar(10)  NOT NULL,
    [kode_bundle] varchar(10)  NULL,
    [kode_roti] varchar(10)  NULL,
    [harga_roti] int  NULL,
    [qty] int  NULL
);
GO

-- Creating table 'diskons'
CREATE TABLE [dbo].[diskons] (
    [kode_diskon] varchar(10)  NOT NULL,
    [tanggal_mulai] date  NULL,
    [tanggal_selesai] date  NULL,
    [harga_before] int  NULL,
    [potongan] int  NULL,
    [harga_after] int  NULL,
    [nama] varchar(100)  NULL,
    [keterangan] varchar(50)  NULL,
    [kode_roti] varchar(10)  NULL
);
GO

-- Creating table 'dtrans'
CREATE TABLE [dbo].[dtrans] (
    [dtrans_id] varchar(10)  NOT NULL,
    [htrans_id] varchar(10)  NULL,
    [kode_roti] varchar(10)  NULL,
    [qty] int  NULL,
    [harga] int  NULL,
    [subtotal] int  NULL
);
GO

-- Creating table 'hbundles'
CREATE TABLE [dbo].[hbundles] (
    [kode_bundle] varchar(10)  NOT NULL,
    [tanggal_mulai] date  NULL,
    [tanggal_selesai] date  NULL,
    [keterangan] varchar(200)  NULL,
    [harga_before] int  NULL,
    [potongan] int  NULL,
    [harga_after] int  NULL
);
GO

-- Creating table 'htrans'
CREATE TABLE [dbo].[htrans] (
    [htrans_id] varchar(10)  NOT NULL,
    [user_id] varchar(10)  NULL,
    [subtotal] int  NULL,
[total_item] int  NULL,
[total_diskon] int  NULL,
    [tanggal] datetime  NULL
);
GO

-- Creating table 'jenis_roti'
CREATE TABLE [dbo].[jenis_roti] (
    [kode_jenis] varchar(10)  NOT NULL,
    [nama] varchar(50)  NULL,
    [exp] int  NULL,
    [status] int  NULL,
    [harga] int  NULL
);
GO

-- Creating table 'rotis'
CREATE TABLE [dbo].[rotis] (
    [kode_roti] varchar(10)  NOT NULL,
    [kode_jenis] varchar(10)  NULL,
    [created_at] date  NULL,
    [expired_at] date  NULL,
    [qty] int  NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [user_id] varchar(10)  NOT NULL,
    [nama] varchar(255)  NULL,
    [password] varchar(255)  NULL,
    [role] varchar(10)  NULL
);
GO

CREATE TABLE [dbo].[transDiskon] (
    [transDiskon_id] varchar(10)  NOT NULL,
    [kode_diskon] varchar(10)  NULL,
[htrans_id] varchar(10)  NULL,
    [potongan] int  NULL,
    [keterangan] varchar(255)  NULL,
);
GO
-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [kode_buang] in table 'buangs'
ALTER TABLE [dbo].[buangs]
ADD CONSTRAINT [PK_buangs]
    PRIMARY KEY CLUSTERED ([kode_buang] ASC);
GO

-- Creating primary key on [kode_dbundle] in table 'dbundles'
ALTER TABLE [dbo].[dbundles]
ADD CONSTRAINT [PK_dbundles]
    PRIMARY KEY CLUSTERED ([kode_dbundle] ASC);
GO

-- Creating primary key on [kode_diskon] in table 'diskons'
ALTER TABLE [dbo].[diskons]
ADD CONSTRAINT [PK_diskons]
    PRIMARY KEY CLUSTERED ([kode_diskon] ASC);
GO

-- Creating primary key on [dtrans_id] in table 'dtrans'
ALTER TABLE [dbo].[dtrans]
ADD CONSTRAINT [PK_dtrans]
    PRIMARY KEY CLUSTERED ([dtrans_id] ASC);
GO

-- Creating primary key on [kode_bundle] in table 'hbundles'
ALTER TABLE [dbo].[hbundles]
ADD CONSTRAINT [PK_hbundles]
    PRIMARY KEY CLUSTERED ([kode_bundle] ASC);
GO

-- Creating primary key on [htrans_id] in table 'htrans'
ALTER TABLE [dbo].[htrans]
ADD CONSTRAINT [PK_htrans]
    PRIMARY KEY CLUSTERED ([htrans_id] ASC);
GO

-- Creating primary key on [kode_jenis] in table 'jenis_roti'
ALTER TABLE [dbo].[jenis_roti]
ADD CONSTRAINT [PK_jenis_roti]
    PRIMARY KEY CLUSTERED ([kode_jenis] ASC);
GO

-- Creating primary key on [kode_roti] in table 'rotis'
ALTER TABLE [dbo].[rotis]
ADD CONSTRAINT [PK_rotis]
    PRIMARY KEY CLUSTERED ([kode_roti] ASC);
GO

-- Creating primary key on [user_id] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([user_id] ASC);
GO

ALTER TABLE [dbo].[transDiskon]
ADD CONSTRAINT [PK_transdiskon]
    PRIMARY KEY CLUSTERED ([transDiskon_id] ASC);
GO
-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [kode_jenis] in table 'buangs'
ALTER TABLE [dbo].[buangs]
ADD CONSTRAINT [FK_FKBUANG_JENIS_ROTI]
    FOREIGN KEY ([kode_jenis])
    REFERENCES [dbo].[jenis_roti]
        ([kode_jenis])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKBUANG_JENIS_ROTI'
CREATE INDEX [IX_FK_FKBUANG_JENIS_ROTI]
ON [dbo].[buangs]
    ([kode_jenis]);
GO

-- Creating foreign key on [kode_roti] in table 'buangs'
ALTER TABLE [dbo].[buangs]
ADD CONSTRAINT [FK_FKBUANG_ROTI]
    FOREIGN KEY ([kode_roti])
    REFERENCES [dbo].[rotis]
        ([kode_roti])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKBUANG_ROTI'
CREATE INDEX [IX_FK_FKBUANG_ROTI]
ON [dbo].[buangs]
    ([kode_roti]);
GO

-- Creating foreign key on [kode_bundle] in table 'dbundles'
ALTER TABLE [dbo].[dbundles]
ADD CONSTRAINT [FK_FKBUNDLE_BUNDLE]
    FOREIGN KEY ([kode_bundle])
    REFERENCES [dbo].[hbundles]
        ([kode_bundle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKBUNDLE_BUNDLE'
CREATE INDEX [IX_FK_FKBUNDLE_BUNDLE]
ON [dbo].[dbundles]
    ([kode_bundle]);
GO

-- Creating foreign key on [kode_roti] in table 'dbundles'
ALTER TABLE [dbo].[dbundles]
ADD CONSTRAINT [FK_FKPRODUCT_ROTI]
    FOREIGN KEY ([kode_roti])
    REFERENCES [dbo].[rotis]
        ([kode_roti])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKPRODUCT_ROTI'
CREATE INDEX [IX_FK_FKPRODUCT_ROTI]
ON [dbo].[dbundles]
    ([kode_roti]);
GO

-- Creating foreign key on [kode_roti] in table 'diskons'
ALTER TABLE [dbo].[diskons]
ADD CONSTRAINT [FK_FKDISKON_ROTI]
    FOREIGN KEY ([kode_roti])
    REFERENCES [dbo].[rotis]
        ([kode_roti])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKDISKON_ROTI'
CREATE INDEX [IX_FK_FKDISKON_ROTI]
ON [dbo].[diskons]
    ([kode_roti]);
GO

-- Creating foreign key on [htrans_id] in table 'dtrans'
ALTER TABLE [dbo].[dtrans]
ADD CONSTRAINT [FK_FKHTRANS_ROTI]
    FOREIGN KEY ([htrans_id])
    REFERENCES [dbo].[htrans]
        ([htrans_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKHTRANS_ROTI'
CREATE INDEX [IX_FK_FKHTRANS_ROTI]
ON [dbo].[dtrans]
    ([htrans_id]);
GO

-- Creating foreign key on [kode_roti] in table 'dtrans'
ALTER TABLE [dbo].[dtrans]
ADD CONSTRAINT [FK_FKKODE_ROTI_HTRANS]
    FOREIGN KEY ([kode_roti])
    REFERENCES [dbo].[rotis]
        ([kode_roti])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKKODE_ROTI_HTRANS'
CREATE INDEX [IX_FK_FKKODE_ROTI_HTRANS]
ON [dbo].[dtrans]
    ([kode_roti]);
GO

-- Creating foreign key on [user_id] in table 'htrans'
ALTER TABLE [dbo].[htrans]
ADD CONSTRAINT [FK_FKUSER_ROTI]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[users]
        ([user_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKUSER_ROTI'
CREATE INDEX [IX_FK_FKUSER_ROTI]
ON [dbo].[htrans]
    ([user_id]);
GO

-- Creating foreign key on [kode_jenis] in table 'rotis'
ALTER TABLE [dbo].[rotis]
ADD CONSTRAINT [FK_FKJENIS_ROTI]
    FOREIGN KEY ([kode_jenis])
    REFERENCES [dbo].[jenis_roti]
        ([kode_jenis])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FKJENIS_ROTI'
CREATE INDEX [IX_FK_FKJENIS_ROTI]
ON [dbo].[rotis]
    ([kode_jenis]);
GO

ALTER TABLE [dbo].[transDiskon]
ADD CONSTRAINT [FK_HTRANS_TRANSDISKON]
    FOREIGN KEY ([htrans_id])
    REFERENCES [dbo].[htrans]
        ([htrans_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE [dbo].[transDiskon]
ADD CONSTRAINT [FK_DISKON_TRANSDISKON]
    FOREIGN KEY ([kode_diskon])
    REFERENCES [dbo].[diskons]
        ([kode_diskon])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE [dbo].[transDiskon]
ADD CONSTRAINT [FK_BUNDLE_TRANSDISKON]
    FOREIGN KEY ([kode_diskon])
    REFERENCES [dbo].[hbundles]
        ([kode_bundle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------



INSERT INTO jenis_roti (kode_jenis, nama, exp, status, harga)
VALUES 
    ('J_R0000001', 'Spicy Floss', 4, 1, 8000),
    ('J_R0000002', 'Sausage Diva', 3, 1, 8000),
    ('J_R0000003', 'Floss Roll', 5, 1, 8000),
    ('J_R0000004', 'Choco Meisis', 4, 1, 8000),
    ('J_R0000005', 'Rendang Floss', 6, 1, 8000),
    ('J_R0000006', 'Floss', 3, 1, 8000),
    ('J_R0000007', 'Milky Bun', 4, 1, 8000),
    ('J_R0000008', 'Coffee Bun', 3, 1, 8000),
    ('J_R0000009', 'Sugar Pillow', 4, 1, 8000),
    ('J_R0000010', 'Choco Bun', 4, 1, 8000),
    ('J_R0000011', 'Croissant Chocolate', 5, 1, 10000),
    ('J_R0000012', 'Sausage Bun', 4, 1, 10000),
    ('J_R0000013', 'Tuna Cheese Puff', 4, 1, 10000),
    ('J_R0000014', 'Cheese Croissant', 4, 1, 10000),
    ('J_R0000015', 'Croisssant', 4, 1, 10000),
    ('J_R0000016', 'Apple Pie', 3, 1, 10000),
    ('J_R0000017', 'Spicy Beef Puff', 4, 1, 10000),
    ('J_R0000018', 'Double Choco', 3, 1, 10000),
    ('J_R0000019', 'Raisin Toast', 3, 1, 19000),
    ('J_R0000020', 'Cheese Swirl Toast', 3, 1, 19000),
    ('J_R0000021', 'Raisin Choco', 3, 1, 19000),
    ('J_R0000022', 'White Toast', 2, 1, 19000),
    ('J_R0000023', 'Unskin-White Toast', 2, 1, 19000),
    ('J_R0000024', 'Whole Meal Toast', 4, 1, 19000),
    ('J_R0000025', 'Plain Mini Bun', 2, 1, 19000),
    ('J_R0000026', 'Whole Meal Toast', 4, 1, 19000),
    ('J_R0000027', 'Choco Cheese', 3, 1, 19000),
    ('J_R0000028', 'Red Velvet Slice', 3, 1, 12000),
    ('J_R0000029', 'Black Forest Slice', 3, 1, 12000),
    ('J_R0000030', 'Chantilly Slice', 4, 1, 12000),
    ('J_R0000031', 'Tiramisu Cup', 4, 1, 12000),
    ('J_R0000032', 'Rich Chocolate Slice', 5, 1, 12000),
    ('J_R0000033', 'Oreo Cup', 4, 1, 12000),
    ('J_R0000034', 'Tiramisu Slice', 6, 1, 12000),
    ('J_R0000035', 'Chantilly Blush Slice', 5, 1, 12000),
    ('J_R0000036', 'Bluberry Cheescake Slice', 6, 1, 12000),
    ('J_R0000037', 'Raisin Cream Cake', 5, 1, 12000),
    ('J_R0000038', 'Rainbow Cake Slice', 3, 1, 12000),
    ('J_R0000039', 'Cheesecake Slice', 3, 1, 12000),
    ('J_R0000040', 'Lapis Surabaya L', 7, 1, 50000),
    ('J_R0000041', 'Lapis Surabaya M', 7, 1, 35000),
    ('J_R0000042', 'Original Almond', 7, 1, 35000),
    ('J_R0000043', 'Choco Almond', 7, 1, 35000),
    ('J_R0000044', 'Kastengel', 7, 1, 35000),
    ('J_R0000045', 'Golden Nastar Kotak', 7, 1, 35000),
    ('J_R0000046', 'Golden Nastar Bulat', 7, 1, 35000),
    ('J_R0000047', 'Chesse Ball', 2, 1, 35000),
    ('J_R0000048', 'Caramel Almond', 3, 1, 35000),
    ('J_R0000049', 'Black Forest', 5, 1, 250000),
    ('J_R0000050', 'Red Velvet', 4, 1, 250000);