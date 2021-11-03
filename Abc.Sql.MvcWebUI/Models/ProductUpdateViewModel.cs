using Abc.Sql.Entities;
using Abc.Sql.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Sql.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}