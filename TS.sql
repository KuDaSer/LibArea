select p.Name ProductName, C.Name CategName
from product p
left join LinksCateg LC on p.id = LC.ProdId
left join Categs C on C.id = LC.CategId
