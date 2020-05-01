SELECT m.Title AS MuralTitle, c.Title AS CatalogTitle
FROM Murals AS m
LEFT JOIN CatalogMurals AS cm ON (m.Id = cm.MuralId)
LEFT JOIN Catalogs AS c ON (c.Id = cm.CatalogId)
GO