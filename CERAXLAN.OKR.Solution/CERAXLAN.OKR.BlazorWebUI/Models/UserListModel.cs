namespace CERAXLAN.OKR.BlazorWebUI.Models
{
    public class UserListModel : BasePageableModel
    {
        public UserListModel()
        {
            Items = new List<UserViewModel>();
        }
        public List<UserViewModel> Items { get; set; }
    }
}
