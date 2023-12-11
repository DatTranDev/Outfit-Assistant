using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OutfitAssistant.Models
{
    public class AppUser 
    {
        [Key]
        public int ID { get; set; }
        public string? UserName {  get; set; }
        public string? PassWord {  get; set; }
        public string? Email {  get; set; }
        public string? FullName {  get; set; }
        public int Age {  get; set; }
        public string? Gender { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public bool IsDeleted { get;set; }
    }
}
