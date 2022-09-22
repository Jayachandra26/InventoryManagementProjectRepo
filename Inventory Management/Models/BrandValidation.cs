using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(BrandMetaData))]
    public partial class Brand
    {
        public class BrandMetaData
        {
            [Required]
            [DisplayName("Brand Name")]
            public string Brand1 { get; set; }
        }
    }
}