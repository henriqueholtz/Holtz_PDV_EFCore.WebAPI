IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Empresa] (
    [EmpCod] int NOT NULL IDENTITY,
    [EmpRaz] nvarchar(max) NULL,
    [EmpFan] nvarchar(max) NULL,
    [EmpCpfCnpj] nvarchar(max) NULL,
    [EmpSts] nvarchar(max) NULL,
    CONSTRAINT [PK_Empresa] PRIMARY KEY ([EmpCod])
);

GO

CREATE TABLE [Filial] (
    [EmpCod] int NOT NULL,
    [FilCod] int NOT NULL,
    CONSTRAINT [PK_Filial] PRIMARY KEY ([EmpCod], [FilCod])
);

GO

CREATE TABLE [Pessoa] (
    [EmpCod] int NOT NULL,
    [PesCod] int NOT NULL,
    [PesRaz] nvarchar(max) NULL,
    [PesFan] nvarchar(max) NULL,
    [PesCpfCnpj] nvarchar(max) NULL,
    CONSTRAINT [PK_Pessoa] PRIMARY KEY ([EmpCod], [PesCod])
);

GO

CREATE TABLE [Produto] (
    [EmpCod] int NOT NULL,
    [ProCod] int NOT NULL,
    [ProNom] nvarchar(max) NULL,
    [ProObs] nvarchar(max) NULL,
    [ProNcm] nvarchar(max) NULL,
    CONSTRAINT [PK_Produto] PRIMARY KEY ([EmpCod], [ProCod])
);

GO

CREATE TABLE [Usuario] (
    [UsuCod] int NOT NULL IDENTITY,
    [UsuNom] nvarchar(max) NULL,
    [UsuSts] nvarchar(max) NULL,
    [UsuTip] nvarchar(max) NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([UsuCod])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200623012156_createTableUsuario', N'3.1.5');

GO

CREATE TABLE [UsuarioEmpresas] (
    [UsuCod] int NOT NULL,
    [EmpCod] int NOT NULL,
    CONSTRAINT [PK_UsuarioEmpresas] PRIMARY KEY ([UsuCod], [EmpCod])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200623012632_createTableUsuarioEmpresas', N'3.1.5');

GO

