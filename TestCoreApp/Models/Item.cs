
using System.ComponentModel.DataAnnotations;

namespace TestCoreApp.Models
{
    public class Item

         
    {
        public int  Id {  get; set; }
        [Required]
        public string name   { get; set; }
        [Required]
        public decimal Price { get; set; }

        public DateTime Created { get; set; } =DateTime.Now;
        
        
     }
}
