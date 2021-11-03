using Abc.Core.DataAccess.EntityFramework;
using Abc.Sql.DataAccess.Abstract;
using Abc.Sql.Entities.Concrete;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Sql.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,SqlContext>,IProductDal
    {
    }
}
