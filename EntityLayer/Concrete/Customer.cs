using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //ilişkili tablolar müşteri ve işi birleştiricez 1-N
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int JopID { get; set; }
        public Jop Jop { get; set; }
    }
}
