using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.Concrete
{
    
    public class JopManager : IJopService
    {
        IJopDal _jopDal;

        public JopManager(IJopDal jopDal)
        {
            _jopDal = jopDal;
        }

        public void TDelete(Jop t)
        {
         _jopDal.Delete(t);

        }

        public Jop TGetById(int id)
        {
          return _jopDal.GetById(id);
        }

        public List<Jop> TGetList()
        {
            return _jopDal.GetList();
        }

        public void TInsert(Jop t)
        {
          _jopDal.Insert(t);
        }

        public void TUpdate(Jop t)
        {
            _jopDal.Updete(t);
        }
    }
}
