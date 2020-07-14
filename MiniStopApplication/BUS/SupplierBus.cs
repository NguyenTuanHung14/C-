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
   public class SupplierBus
    {
        private static SupplierBus instance;

        public static SupplierBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new SupplierBus();
                return instance;
            }
        }
        private SupplierBus() { }

        public DataTable GetAllSupplier()
        {
            try
            {
                return ProcessSupplier.Instance.getAllSupplier();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertSupplier(Supplier supplier)
        {
            try
            {
                return ProcessSupplier.Instance.InserSupplier(supplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                return ProcessSupplier.Instance.UpdateSupplier(supplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteSupplier(int id_supplier)
        {
            try
            {
                return ProcessSupplier.Instance.DeleteSupplier(id_supplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
