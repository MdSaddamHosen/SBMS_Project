using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;

namespace SBMS.BLL
{
   public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
       
         
        public bool insertvalue(Categories categories)

        {
            return _categoryRepository.insertvalue(categories);
        }
        public bool IsNameexist(Categories categories)
        {
            return _categoryRepository.IsNameexist(categories);
        }

        public bool IsCodeexist(Categories categories)
        {
            return _categoryRepository.IsCodeexist(categories);
        }

        public List<Categories> show(Categories categories)
        {
            return _categoryRepository.show();
        }

        public bool update(Categories categories)
        {
            return _categoryRepository.update(categories);
        }

        public bool delete(Categories categories)
        {
            return _categoryRepository.delete(categories);
        }

        public List<Categories> Search(string code,string name)
        {
            return _categoryRepository.Search(code,name);
        }

       
    }


   
}
