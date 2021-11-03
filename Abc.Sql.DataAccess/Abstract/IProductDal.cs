using Abc.Core.DataAccess;
using Abc.Sql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Sql.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
