using DataAccessLayer.Abstract;
using DataAccessLayer.Contcrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepositori<Customer>, ICustomerDal
    { //ınclude işlemi ile mesleklerin tabloyu tablodaki karşılığını getiriyoruz
        //2.işlem business gidelim
        
       
        public List<Customer> GetCustomerListWithJop()
        {
            using(var c = new Context())
            {
                return c.Customers.Include(x => x.Jop).ToList();
            }
        }
    }
}
