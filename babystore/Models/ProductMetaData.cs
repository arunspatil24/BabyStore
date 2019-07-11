using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace babystore.Models
{
    [MetadataType (typeof(ProductMetaData))]
    public partial class Product
    {

    }
    public class ProductMetaData
    {
        [Display(Name = "Product Name")]
        public String Name;
    }
}