namespace FirstActivity_POO
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public string Products { get; set; }

        public override decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
