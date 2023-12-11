using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutfitAssistant.Models
{
    
    public class UserProduct
    {
        [ForeignKey("AppUser")]
        public int IDUser { get; set; }
        public AppUser? AppUser { get; set; }
        [ForeignKey("Product")]
        public int IDProduct { get; set; }
        public Product? Product { get; set; }
        public int? Count {  get; set; }
        public decimal? TotalPrice { get; set; }
        public System.DateTime CreateAt {  get; set; }
    }
}
