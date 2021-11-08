using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BulmaTutorial.Models
{
    public class BulmaExample
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the food you like!")]
        [StringLength(50)]
        public string Food { get; set; }

        [Required(ErrorMessage = "Please enter the food's category.")]
        [StringLength(40)]
        public string Category { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Please enter the brand of food.")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please enter the rounded cost of the food.")]
        [Range(0, 100, ErrorMessage = "Please enter the rounded cost of the food between 0 and 100.")]
        [DataType(DataType.Currency)]
        public int Cost { get; set; }

        
    }
}
