namespace CsharpAdvance.Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }



    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class Book : Product
    {
        public string Isbn { get; set; }
    }
}