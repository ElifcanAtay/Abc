using Abc.Sql.Entities;
using Abc.Sql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Sql.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; internal set; }
        public Product Product { get; set; }
    }
}
