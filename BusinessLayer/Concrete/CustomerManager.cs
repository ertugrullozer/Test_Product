using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
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
        ICustomerDal _customerDal;


        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        //implemente ediyoruz ve metot tanımlıyoruz 
        //4.işlem customercontroler gidiyoruz
        public List<Customer> GetCustomerListWithJop()
        {
           return _customerDal.GetCustomerListWithJop();
        }

   

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public Customer TGetById(int id)
        {
           return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
           return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
          _customerDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
          _customerDal.Updete(t);
        }

  
    }
}
