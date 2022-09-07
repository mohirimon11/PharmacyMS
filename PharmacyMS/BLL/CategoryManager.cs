using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyMS.Model;
using PharmacyMS.Repositopry;
using System.Data;

namespace PharmacyMS.BLL
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool Add(Category category)
        {
            return _categoryRepository.Add(category);
        }
        public bool Update(Category category)
        {
            return _categoryRepository.Update(category);
        }
        public DataTable Search(Category category)
        {
            return _categoryRepository.Search(category);
        }
        public bool UpdateIsCodeExists(Category category)
        {
            return _categoryRepository.UpdateIsCodeExists(category);
        }
        public bool IsNameExists(Category category)
        {
            return _categoryRepository.IsNameExists(category);
        }
        public bool UpdateIsNameExists(Category category)
        {
            return _categoryRepository.UpdateIsNameExists(category);
        }
        public DataTable Display()
        {
            return _categoryRepository.Display();
        }
        public bool IsCodeExists(Category category)
        {
            return _categoryRepository.IsCodeExists(category);
        }
    }
}
