namespace ShopList.model
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Grammage { get; set; }
        public Categories Category { get; set; }
        public bool IsSelected { get; set; }
        public ProductModel(string name, int g, int c)
        {
            Name = name;
            Grammage = g.ToString();
            Category = (Categories)c;
        }
    }
}
