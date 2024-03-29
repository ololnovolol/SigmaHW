﻿using Products.Task1_Task2.Enums;

namespace Products.Task1_Task2.Products
{
    internal class Meat : Product
    {
        readonly Category category;
        readonly MeatType meatType;

        public Meat(Category category, MeatType meatType, decimal price, int weight) : base($"Meat_{category}_{meatType}", price, weight)
        {
            this.category = category;
            this.meatType = meatType;
        }
        public Meat() : base(string.Empty, default, default)
        {
            category = Category.NaN;
            meatType = MeatType.Nan;
        }

        public void ChangePriceByCategory(int percent)
        {
            if (category == Category.TopGrade)
                base.ChangePrice(percent + (percent * 25 / 100));

            if (category == Category.SecondGrade)
                base.ChangePrice(percent + (percent * 15 / 100));
        }

        public void ChangePriceByType(int percent)
        {
            if (meatType == MeatType.Lamb)
                base.ChangePrice(percent - (percent * 2 / 100));

            if (meatType == MeatType.Veal)
                base.ChangePrice(percent - (percent * 3 / 100));

            if (meatType == MeatType.Pork)
                base.ChangePrice(percent - (percent * 5 / 100));

            if (meatType == MeatType.Chicken)
                base.ChangePrice(percent - (percent * 7 / 100));
        }

        public override string ToString()
        {
            return string.Format($"Product  Name: {Name}, Price: {Price}, Weight: {Weight}");
        }

        public override bool Equals(object obj)
        {
            return obj is Product product && Equals((Product)obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
