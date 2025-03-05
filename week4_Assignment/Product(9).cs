namespace Assessment_Inheritance_
{
    public class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }

        public virtual decimal GetDiscountedPrice()
        {
            
            return Price;
        }
    }

    public class ElectronicProduct : Product
    {
        public override decimal GetDiscountedPrice()
        {
            
            return Price * 0.9m;
        }
    }

    public class ClothingProduct : Product
    {
        public override decimal GetDiscountedPrice()
        {
            
            return Price * 0.8m;
        }
    }

    //    public class Program9
    //    {
    //        public static void Main(string[] args)
    //        {
    //            Product electronic = new ElectronicProduct { Name = "Laptop", Price = 1000m };
    //            Product clothing = new ClothingProduct { Name = "T-Shirt", Price = 50m };

    //            Console.WriteLine($"Product: {electronic.Name}, Original Price: {electronic.Price}, Discounted Price: {electronic.GetDiscountedPrice()}");
    //            Console.WriteLine($"Product: {clothing.Name}, Original Price: {clothing.Price}, Discounted Price: {clothing.GetDiscountedPrice()}");
    //        }
    //    }
}
