using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Filtering.Templates;
using MiniStopApplication.DTO;
namespace MiniStopApplication.DAO
{
   public class ProcessProduct
    {
    
        private static ProcessProduct instance;
        public static ProcessProduct Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProcessProduct();
                return ProcessProduct.instance;
            }
        }

        public DataTable GetAllProduct()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_Product");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllProductForCheckOut()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_ProductForCheckOut");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllProductByType(int id_productType)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetByType_Product @Id_productType", new object[] { id_productType });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable SearchProduct(string text)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetByName_Product @name_product", new object[] { text });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertProduct(Product product) {
            string query = string.Format("SP_Insert_Product @name_product , @price , @amount , @image , @mFG_date , @eXP_date , @discount , @id_ProductType");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { product.Name_product, product.Price, product.Amount, product.Image,product.MFG_date, product.EXP_date, product.Discount, product.Id_ProductType });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool DeleteProduct(int Id_product) {
            string query = string.Format("SP_Delete_Product @Id_product");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Id_product });
            }
            catch (Exception ex) {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateProduct(Product product) {
            string query = string.Format("SP_Update_Product @id_product , @name_product , @price , @amount , @image , @mFG_date , @eXP_date , @discount , @id_ProductType");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { product.Id_product, product.Name_product, product.Price, product.Amount, product.Image, product.MFG_date, product.EXP_date, product.Discount, product.Id_ProductType });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
