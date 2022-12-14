using CERAXLAN.Core.Persistence.Repositories;

namespace CERAXLAN.OKR.ProductApi.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
