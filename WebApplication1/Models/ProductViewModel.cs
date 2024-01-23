using System.ComponentModel;

namespace WebApplication1.Data
{
    public class ProductViewModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public double Price { get; set; } = 0.0;
        public int PackQuantity { get; set; } = 0;
        public string BrandName { get; set; }
        public double Length { get; set; }= 0.0;
        public double Weight { get; set; } = 0.0;
        public CategoryViewModel Category { get; set; }
        public List<ProductColorViewModel> ProductColors { get; set; }
    }

    public class ProductListViewModel
    {
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }

}
