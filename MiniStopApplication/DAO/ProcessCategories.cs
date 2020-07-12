using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStopApplication.DTO;
using DevExpress.DataProcessing;

namespace MiniStopApplication.DAO
{
    public class ProcessCategories
    {
        private static ProcessCategories instance;
        public static ProcessCategories Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProcessCategories();
                return ProcessCategories.instance;
            }
        }

        public DataTable getListCategory() {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_ProductType");
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public bool InsertCategory(Categories categories )
        {
            string query = string.Format("SP_Insert_ProductType @Name");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { categories.Name_category});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool DeleteCategory(int Id_ProductType)
        {
            string query = string.Format("SP_Delete_ProductType @Id_ProductType");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Id_ProductType });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public DataTable  getCategoryById(int Id_ProductType) {
     
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetById_ProductType @Id_ProductType");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
