using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {

        public class CategoryMetaData
        {
            [DisplayName("Category Name")]
            public string Category1 { get; set; }
        }

    }
}
