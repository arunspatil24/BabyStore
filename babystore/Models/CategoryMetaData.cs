using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace babystore.Models
{
    [MetadataType (typeof(CategoryMetaData))]
    public partial class Category
    {

    }
    public class CategoryMetaData
    {
        [Display(Name = "Category Name")]
        public string Name;
    }
}