using System.ComponentModel;

namespace WebApplication1.Data
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; } = 0.0;
        public int PackQuantity { get; set; } = 0;
        public string BrandName { get; set; }
        public double Length { get; set; }= 0.0;
        public double Weight { get; set; } = 0.0;
        public Category Category { get; set; }
        public List<ProductColor> ProductColors { get; set; }
    }
}
