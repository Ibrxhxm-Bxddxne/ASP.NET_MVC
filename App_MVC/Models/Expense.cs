using System.ComponentModel.DataAnnotations;

namespace App_MVC.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Valeur { get; set; }
        [Required] 
        public string? Description { get; set; }
    }
}
