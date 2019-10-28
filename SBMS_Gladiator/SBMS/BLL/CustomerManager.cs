using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.Repository;

namespace SBMS.BLL
{
  public  class CustomerManager
    {
        CustomerReporsitory _customerReporsitory = new CustomerReporsitory();

        public bool insertvalue(Customers customers)

        {
            return _customerReporsitory.insertvalue(customers);
        }

        public bool IsCodeexist(Customers customers)
        {
            return _customerReporsitory.IsCodeexist(customers);
        }

        public bool IsEmailexist(Customers customers)
        {
            return _customerReporsitory.IsEmailexist(customers);
        }

        public bool IsContactexist(Customers customers)
        {
            return _customerReporsitory.IsContactexist(customers);
        }
        public List<Customers> show()
        {
            return _customerReporsitory.show();
        }
        public bool update(Customers customers)

        {
            return _customerReporsitory.update(customers);
        }

        public bool delete(Customers customers)
        {
            return _customerReporsitory.delete(customers);
        }

        public List<Customers> Search(string name, string email, string contact)
        {
            return _customerReporsitory.Search(name, email, contact);
        }
    }
}
