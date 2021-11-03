using Abc.Core.DataAccess.EntityFramework;
using Abc.Sql.DataAccess.Abstract;
using Abc.Sql.Entities;


namespace Abc.Sql.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, SqlContext>,ICategoryDal
    {
    }
}
