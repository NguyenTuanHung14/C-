using DevExpress.XtraEditors.Filtering.Templates;
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
    class ProductBus
    {
        private static ProductBus instance;

        public static ProductBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductBus();
                return instance;
            }
        }
        private ProductBus() { }

        public DataTable GetAllProduct()
        {
            try
            {
                return ProcessProduct.Instance.GetAllProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertProduct(Product product)
        {
            try
            {
                return ProcessProduct.Instance.InsertProduct(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
