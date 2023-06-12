CREATE TABLE [dbo].[ProductCategory] (
    [ProductId]  INT NOT NULL,
    [CategoryId] INT NOT NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([ProductId] ASC, [CategoryId] ASC),
    CONSTRAINT [FK_ProductCategory_ToTable] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_ProductCategory_ToTable_1] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);