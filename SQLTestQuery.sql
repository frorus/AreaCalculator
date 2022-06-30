SELECT Products.Name, Categories.Name
  FROM Products
LEFT JOIN ProductCategory
  ON Products.Id = ProductCategory.ProductsId
LEFT JOIN Categories
  ON Categories.Id = ProductCategory.CategoriesId
ORDER BY Products.Name