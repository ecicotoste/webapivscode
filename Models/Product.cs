using System.ComponentModel.DataAnnotations;

namespace RedBager.Models
{
    public class Product
    {
        [Key]
        public int ID {get; set;}
        public string Title {get; set;}
         public string Description {get; set;}
         public decimal Price {get; set;}
         public int CategoryId {get; set;}
         public Category Category {get; set;}

    }
}