Select c.name,c.street From customers c where c.city='Porto Alegre'
Select p.id,p.name From products p where p.price<10 OR p.price>100
Select p.name,pr.name

From products p,providers pr

where p.id_categories=6 and p.id_providers=pr.id

Select p.id,p.name From products p  join categories c on p.id_categories=c.id where c.name Like 'super%'

Select p.city From providers p order by p.city asc
Select max(p.price) as price ,min(p.price) as price From products p