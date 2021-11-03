using Abc.Sql.Business.Abstract;
using Abc.Sql.DataAccess.Abstract;
using Abc.Sql.Entities;
using System.Collections.Generic;

namespace Abc.Sql.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category category)
        {
            throw new System.NotImplementedException();
        }
    }
}
