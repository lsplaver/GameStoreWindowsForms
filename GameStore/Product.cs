namespace GameStore
{
    public class Product
    {
        public Product() { }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public Product(string code, string name, string price) {Code = code; Name = name; Price = price; }

        public string GetDisplayText() => Code + ": " + Name + " $" + Price;
    }
}