IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Blogs] (
    [BlogId] int NOT NULL,
    [Url] nvarchar(max) NULL,
    [Inserted] datetime2 NOT NULL,
    CONSTRAINT [PK_Blogs] PRIMARY KEY ([BlogId])
);

GO

CREATE TABLE [Posts] (
    [PostId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Content] nvarchar(max) NULL,
    [BlogId] int NOT NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY ([PostId]),
    CONSTRAINT [FK_Posts_Blogs_BlogId] FOREIGN KEY ([BlogId]) REFERENCES [Blogs] ([BlogId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Posts_BlogId] ON [Posts] ([BlogId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191208144354_Initial', N'3.1.0');

GO

ALTER TABLE [Blogs] ADD [LastUpdated] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191208145205_UpdatedModel', N'3.1.0');

GO

ALTER TABLE [Blogs] ADD [Timestamp] rowversion NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191208154011_UpdatedModel1', N'3.1.0');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Blogs]') AND [c].[name] = N'Url');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Blogs] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Blogs] ALTER COLUMN [Url] nvarchar(450) NULL;

GO

CREATE UNIQUE INDEX [IX_Blogs_Url] ON [Blogs] ([Url]) WHERE [Url] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191208170730_AddedIndex', N'3.1.0');

GO

ALTER TABLE [Blogs] ADD [Test] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191208173901_AddedBackingField', N'3.1.0');

GO

ALTER TABLE [Posts] ADD [PostType] nvarchar(max) NOT NULL DEFAULT N'';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191208180754_AddedvalueConversion', N'3.1.0');

GO

