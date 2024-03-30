using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerService _customerService;

        public CustomerManager(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public void TDelete(Customer t)
        {
            _customerService.TDelete(t);
        }

        public Customer TGetById(int id)
        {
           return _customerService.TGetById(id);
        }

        public List<Customer> TGetList()
        {
           return _customerService.TGetList();
        }

        public void TInsert(Customer t)
        {
          _customerService.TInsert(t);
        }

        public void TUpdate(Customer t)
        {
           _customerService.TUpdate(t);
        }
    }
}
