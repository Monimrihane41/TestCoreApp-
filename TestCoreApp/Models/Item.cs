
using System.ComponentModel.DataAnnotations;

namespace TestCoreApp.Models
{
    public class Item

         
    {
        public int  Id {  get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]

        public decimal Price { get; set; }

        public DateTime Created { get; set; } =DateTime.Now;
        
        
     }
}
