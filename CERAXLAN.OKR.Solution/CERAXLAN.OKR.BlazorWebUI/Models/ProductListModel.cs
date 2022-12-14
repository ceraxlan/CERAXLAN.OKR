namespace CERAXLAN.OKR.BlazorWebUI.Models
{
    public class ProductListModel : BasePageableModel
    {
        public ProductListModel()
        {
            Items = new List<ProductViewModel>();
        }
        public List<ProductViewModel> Items { get; set; }
    }
}
