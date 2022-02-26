﻿namespace FirstActivity_POO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public  List <Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal accountant = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                accountant += Products[i].ValueToPay();
            }
            return accountant - (accountant * (decimal)Discount);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tDiscount...:{$"{Discount:P2}",13}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",13}";
        }
    }
}
