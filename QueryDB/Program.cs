using System;

namespace QueryDB
{
    class Program
    {
        static void Main(string[] args)
        {
            /* В базе данных MS SQL Server есть продукты и категории.
         * Одному продукту может соответствовать много категорий, 
         * в одной категории может быть много продуктов.
         * Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
         * Если у продукта нет категорий, то его имя все равно должно выводиться.
         * 
         * Также без выполненного задания отклик не будет рассмотрен.
         * Github или Pastebin всё еще удобнее чем поле на hh. 
         * По возможности — положите ответ рядом с кодом из первого вопроса.
*/
            //РЕШЕНИЕ: 
            //var leftJoinedDb = (from p in productsDb
            //                    join c in categoriesDb on p.categoryName equals c.name into leftd
            //                    from pc in leftd.DefaultIfEmpty()
            //                    select new { ProductName = p.ProductName, CategoryName = pc?.CategoryName }).ToList();

        }
    }
}
