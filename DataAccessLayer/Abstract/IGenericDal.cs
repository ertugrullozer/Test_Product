using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Tanımlamıış olduğumuz Arayüzleri olabildiğince toplu hale getirelim
    public interface IGenericDal<T>where T : class 
    {
        void Insert(T t);
        void Delete(T t);
        void Updete(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
