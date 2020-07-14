using DevExpress.Charts.Native;
using DevExpress.ClipboardSource.SpreadsheetML;
using MiniStopApplication.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.DAO
{
    public class ProcessSupplier
    {
        private static ProcessSupplier instance;
        public static ProcessSupplier Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProcessSupplier();
                return ProcessSupplier.instance;
            }
        }

        public DataTable getAllSupplier() {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SP_GetAll_Supplier");
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public bool InserSupplier(Supplier supplier) {
            int result;
            string query = string.Format("SP_Insert_Supplier @Name , @Address , @Phone , @Image");
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { supplier.Name,supplier.Address,supplier.Phone,supplier.HinhAnh });

            }
            catch (Exception ex) {
                throw ex;
            }
            return result > 0;
        }

        public bool DeleteSupplier(int id)
        {
            string query = string.Format("SP_Delete_Supplier @Id");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            int result;
            string query = string.Format("SP_Update_Supplier @Id , @Name , @Address , @Phone , @Image");
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] {supplier.Id, supplier.Name, supplier.Address, supplier.Phone, supplier.HinhAnh });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
