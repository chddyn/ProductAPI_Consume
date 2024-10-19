using System.Text.Json.Serialization;

namespace ProductAPI_Consume.Models
{
    public class ProductDTO
    {

        public int productId { get; set; }

        public string productName { get; set; } = null!;
        public decimal Price { get; set; }

    }
}
