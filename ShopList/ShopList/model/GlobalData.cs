using ShopList.ViewModel;

namespace ShopList.model
{
    public static class GlobalData
    {
        public static ProductViewModel productView { get; set; } = new ProductViewModel();
        public static string fileName { get; set; } = "db.json";
    }
}
