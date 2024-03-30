using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{

    //ilişkili tablolar kullanımı
    //her bir müşterinin bir işi olsun
    public class Jop
    {
        public int JopID { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
