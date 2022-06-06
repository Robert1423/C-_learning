using Newtonsoft.Json;
using ShopList.model;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace ShopList.ViewModel
{
    public class ProductViewModel
    {
        public ObservableCollection<ProductModel> Products { get; set; }
        public ObservableCollection<ProductModel> FiltredList { get; set; }
        public ProductViewModel()
        {
            Products = new ObservableCollection<ProductModel>();
            FiltredList = new ObservableCollection<ProductModel>();
        }
        public void AddProduct(ProductModel product)
        {
            Products.Add(product);
        }
        public void RemoveProducts()
        {
            var selectedList = Products.Where(x => x.IsSelected).ToList();
            foreach(var product in selectedList)
            {
                Products.Remove(product);
            }
        }
        public void Filtr(int index)
        {
            FiltredList.Clear();
            foreach (var item in Products)
            {
                if (index == (int)item.Category)
                    FiltredList.Add(item);
            }
        }
        public void Save()
        {
            if (File.Exists(GlobalData.fileName))
                File.Delete(GlobalData.fileName);
            File.WriteAllText(GlobalData.fileName, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        public void Load()
        {
            if (File.Exists(GlobalData.fileName))
            {
                ProductViewModel temp = JsonConvert.DeserializeObject<ProductViewModel>(File.ReadAllText(GlobalData.fileName));
                Products = temp.Products;
            }
        }
    }
}
