using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcWebApp.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Enter Product Name")]
        [Required(ErrorMessage = "{0} is required.")]
        public string ProductName { get; set; }

        [Display(Name = "Enter Product Category")]
        public string Category { get; set; }

        [Display(Name = "Enter Unit Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required(ErrorMessage = "{0} is required.")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Units in Stock")]
        public bool UnitsInStock { get; set; }
    }

}