using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {   //1.adım efcustomer gidiyoruz
        List<Customer> GetCustomerListWithJop();
    }
}
