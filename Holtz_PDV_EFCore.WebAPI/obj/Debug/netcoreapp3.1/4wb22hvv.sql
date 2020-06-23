IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Empresas] (
    [EmpCod] int NOT NULL IDENTITY,
    [EmpRaz] nvarchar(max) NULL,
    [EmpFan] nvarchar(max) NULL,
    [EmpCpfCnpj] nvarchar(max) NULL,
    [EmpSts] nvarchar(max) NULL,
    CONSTRAINT [PK_Empresas] PRIMARY KEY ([EmpCod])
);

GO

CREATE TABLE [Filiais] (
    [EmpCod] int NOT NULL,
    [FilCod] int NOT NULL,
    [EmpresaEmpCod] int NULL,
    CONSTRAINT [PK_Filiais] PRIMARY KEY ([EmpCod], [FilCod]),
    CONSTRAINT [FK_Filiais_Empresas_EmpresaEmpCod] FOREIGN KEY ([EmpresaEmpCod]) REFERENCES [Empresas] ([EmpCod]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Pessoas] (
    [EmpCod] int NOT NULL,
    [PesCod] int NOT NULL,
    [EmpresaEmpCod] int NULL,
    [PesRaz] nvarchar(max) NULL,
    [PesFan] nvarchar(max) NULL,
    [PesCpfCnpj] nvarchar(max) NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([EmpCod], [PesCod]),
    CONSTRAINT [FK_Pessoas_Empresas_EmpresaEmpCod] FOREIGN KEY ([EmpresaEmpCod]) REFERENCES [Empresas] ([EmpCod]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Produtos] (
    [EmpCod] int NOT NULL,
    [ProCod] int NOT NULL,
    [EmpresaEmpCod] int NULL,
    [ProNom] nvarchar(max) NULL,
    [ProObs] nvarchar(max) NULL,
    [ProNcm] nvarchar(max) NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([EmpCod], [ProCod]),
    CONSTRAINT [FK_Produtos_Empresas_EmpresaEmpCod] FOREIGN KEY ([EmpresaEmpCod]) REFERENCES [Empresas] ([EmpCod]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Filiais_EmpresaEmpCod] ON [Filiais] ([EmpresaEmpCod]);

GO

CREATE INDEX [IX_Pessoas_EmpresaEmpCod] ON [Pessoas] ([EmpresaEmpCod]);

GO

CREATE INDEX [IX_Produtos_EmpresaEmpCod] ON [Produtos] ([EmpresaEmpCod]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200623003422_initial', N'3.1.5');

GO

