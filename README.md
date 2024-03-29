# mindbox-test-task

## Задание 2 
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

## Решение 
Ввиду того что в задании не даны описания структур таблиц, поэтому могу предположить что таблицы устроены примерно следующим образом. Есть две таблицы с данными это Products и Categories с первичными ключами, которые соденины между собой промежуточной таблицей. Примерно таким образом: 

Products:
* ProductID (ID продукта)
* ProductName (Имя продукта)

Categories:
* CategoryID (ID категории)
* CategoryName (Имя категории)

ProductCategories:
* ProductID (ID продукта)
* CategoryID (ID категории)

Если утверждения выше верны, тогда запрос будет выглядеть следующим обазом: 

```
SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName, c.CategoryName;
```
