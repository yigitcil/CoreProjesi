using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    /* 
       Business katmanında Abstract klasörü içerisinde yer alan Interfaceler: Service olarak adlandırılır.
       Busines katmanında Concrete klasörü içerisinde yer alan Sınıflar: Manager olarak adlandırılır.
     */
    /* Blog
     * Blog adı boş geçilemez
     * Yazılma tarihi boş geçilemez
     * Blogun mutlaka bir kategorisi olmak zorunda
     */
    public class CategoryManager : ICategoryService
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
		private EfCategoryRepository efCategoryRepository;

		ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
			if(category.CategoryID !=0)
			 {
				efCategoryRepository.Delete(category);
			 }
			
		}

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            return null;
        }
    }
}
