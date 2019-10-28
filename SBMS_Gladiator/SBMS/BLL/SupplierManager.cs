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
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();

        public bool insertvalue(Suppliers suppliers)

        {
            return _supplierRepository.insertvalue(suppliers);
        }

        public bool IsCodeexist(Suppliers suppliers)
        {
            return _supplierRepository.IsCodeexist(suppliers);
        }

        public bool IsEmailexist(Suppliers suppliers)
        {
            return _supplierRepository.IsEmailexist(suppliers);
        }

        public bool IsContactexist(Suppliers suppliers)
        {
            return _supplierRepository.IsContactexist(suppliers);
        }
        public List<Suppliers> show()
        {
            return _supplierRepository.show();
        }
        public bool update(Suppliers suppliers)

        {
            return _supplierRepository.update(suppliers);
        }

        public bool delete(Suppliers suppliers)
        {
            return _supplierRepository.delete(suppliers);
        }

        public List<Suppliers> Search(string name, string email, string contact)
        {
            return _supplierRepository.Search(name, email, contact);
        }
    }
}
