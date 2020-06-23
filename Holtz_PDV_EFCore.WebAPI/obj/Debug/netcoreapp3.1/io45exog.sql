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

ALTER TABLE [Filiais] DROP CONSTRAINT [FK_Filiais_Empresas_EmpresaEmpCod];

GO

ALTER TABLE [Pessoas] DROP CONSTRAINT [FK_Pessoas_Empresas_EmpresaEmpCod];

GO

ALTER TABLE [Produtos] DROP CONSTRAINT [FK_Produtos_Empresas_EmpresaEmpCod];

GO

ALTER TABLE [Produtos] DROP CONSTRAINT [PK_Produtos];

GO

DROP INDEX [IX_Produtos_EmpresaEmpCod] ON [Produtos];

GO

ALTER TABLE [Pessoas] DROP CONSTRAINT [PK_Pessoas];

GO

DROP INDEX [IX_Pessoas_EmpresaEmpCod] ON [Pessoas];

GO

ALTER TABLE [Filiais] DROP CONSTRAINT [PK_Filiais];

GO

DROP INDEX [IX_Filiais_EmpresaEmpCod] ON [Filiais];

GO

ALTER TABLE [Empresas] DROP CONSTRAINT [PK_Empresas];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Produtos]') AND [c].[name] = N'EmpresaEmpCod');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Produtos] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Produtos] DROP COLUMN [EmpresaEmpCod];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pessoas]') AND [c].[name] = N'EmpresaEmpCod');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Pessoas] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Pessoas] DROP COLUMN [EmpresaEmpCod];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Filiais]') AND [c].[name] = N'EmpresaEmpCod');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Filiais] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Filiais] DROP COLUMN [EmpresaEmpCod];

GO

EXEC sp_rename N'[Produtos]', N'Produto';

GO

EXEC sp_rename N'[Pessoas]', N'Pessoa';

GO

EXEC sp_rename N'[Filiais]', N'Filiai';

GO

EXEC sp_rename N'[Empresas]', N'Empresa';

GO

ALTER TABLE [Produto] ADD CONSTRAINT [PK_Produto] PRIMARY KEY ([EmpCod], [ProCod]);

GO

ALTER TABLE [Pessoa] ADD CONSTRAINT [PK_Pessoa] PRIMARY KEY ([EmpCod], [PesCod]);

GO

ALTER TABLE [Filiai] ADD CONSTRAINT [PK_Filiai] PRIMARY KEY ([EmpCod], [FilCod]);

GO

ALTER TABLE [Empresa] ADD CONSTRAINT [PK_Empresa] PRIMARY KEY ([EmpCod]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200623010519_initial2', N'3.1.5');

GO

