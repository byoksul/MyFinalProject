using Business.Abstract;
using Core.Utilities.Results;
using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            // İşKodları Yazılacak..

            return new SuccessDataResult<List<Category>>( _categoryDal.GetAll());

            
        }
        // Select * from Categories wwhere CategoryId = 3

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));

        }
    }
}
