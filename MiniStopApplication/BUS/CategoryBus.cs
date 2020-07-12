
using MiniStopApplication.DAO;
using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS
{
    class CategoryBus
    {
        private static CategoryBus instance;

        public static CategoryBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryBus();
                return instance;
            }
        }
        private CategoryBus() { }

        public DataTable GetAllProductType()
        {
            try
            {
                return ProcessCategories.Instance.getListCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetProductTypeById(int id_productType)
        {
            try
            {
                return ProcessCategories.Instance.getCategoryById(id_productType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertCategory(Categories categories)
        {
            try
            {
                return ProcessCategories.Instance.InsertCategory(categories);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteCategory(int id_productType)
        {
            try
            {
                return ProcessCategories.Instance.DeleteCategory(id_productType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}
