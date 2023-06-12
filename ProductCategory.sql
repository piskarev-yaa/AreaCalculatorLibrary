select Products.Name as ProductName, Categories.Name as CategoryName from dbo.Products 
left join ProductCategory on Products.Id = ProductCategory.ProductId
left join Categories on CategoryId = Categories.Id