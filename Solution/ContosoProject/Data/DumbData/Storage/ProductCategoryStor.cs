using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DumbData
{
    public static partial class Storage
    {
        public static List<ProductCategory> categoryCollection = new List<ProductCategory>()
        {
            new ProductCategory()
            {
                CategoryName = "Стулья",
            },
                        new ProductCategory()
            {
                CategoryName = "Столы",
            },
                        new ProductCategory()
            {
                CategoryName = "Шкафы",
            },
                        new ProductCategory()
            {
                CategoryName = "Диваны",
            },
                        new ProductCategory()
            {
                CategoryName = "Кровати",
            },
                        new ProductCategory()
            {
                CategoryName = "Полки",
            },
                        new ProductCategory()
            {
                CategoryName = "Кухонная мебель",
            },
                        new ProductCategory()
            {
                CategoryName = "Фурнитура",
            },
                        new ProductCategory()
            {
                CategoryName = "Комоды",
            },
                        new ProductCategory()
            {
                CategoryName = "Тумбы",
            }
        };
    }
}
