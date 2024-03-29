﻿using Products.Task1_Task2.Products;
using System.Collections.Generic;

namespace Products.Task1_Task2
{
    internal class Buy
    {
        private List<Product> Products { get; }

        public int Count { get; private set; }

        public decimal TotalPrice { get; private set; }


        public Buy(Product product, int count)
        {
            Products = new List<Product>();
            Products.Add(product);
            Count += count;
            TotalPrice += (product.Price * count);
        }

        public void Add(Product product, int count)
        {
            Products.Add(product);
            Count += count;
            TotalPrice += (product.Price * count);
        }

        public Buy()
        {
            Products = new List<Product>();
            Count = 0;
            TotalPrice = 0;
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (var item in Products)
            {
                result += string.Format($"Info for Buy:\n  Name: {Products}, Count: {Count}, TotalPrice: {TotalPrice}\n");
            }
            return result;
        }
    }
}
