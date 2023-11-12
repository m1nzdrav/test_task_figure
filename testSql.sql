SELECT p.name,c.name from products p
    left join categories c on p.category_id = c.id 