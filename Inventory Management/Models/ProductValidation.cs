using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
        public class ProductMetaData
        {
            [Required]
            [DisplayName("Product Name")]
            public string Product1 { get; set; }
            

            [DisplayName("Category")]
            public Nullable<int> Category { get; set; }
            

            [DisplayName("Brand")]
            public Nullable<int> Brand { get; set; }
            [Required]

            [DisplayName("Quantity")]
            public Nullable<int> Quantity { get; set; }
            [Required]

            [DisplayName("Price")]
            public Nullable<decimal> Price { get; set; }
            

            [DisplayName("Brand")]
            public virtual Brand Brand1 { get; set; }
            

            [DisplayName("Category")]
            public virtual Category Category1 { get; set; }




        }
    }
}