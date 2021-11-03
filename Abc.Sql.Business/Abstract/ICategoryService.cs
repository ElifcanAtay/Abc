using Abc.Sql.Entities;
using System.Collections.Generic;

namespace Abc.Sql.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);

    }
}
