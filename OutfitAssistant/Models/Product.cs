using System.ComponentModel.DataAnnotations;

namespace OutfitAssistant.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Currency { get; set; }
        public decimal Price { get; set; }
        public string Availability { get;set; }
        public string? Images { get; set; }
        public decimal AvgRating { get; set; }
        public int ReviewCount { get; set; }
        public System.DateTime ScrapedAt{ get; set; }
        public string? Url { get; set; }
        public bool IsDeleted { get; set; }
    }
}
