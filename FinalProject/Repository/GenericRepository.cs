using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FinalProject.Repository
{
    public abstract class GenericRepository<T> : IGenericRespository<T> where T : class
    {
        List<T> l = new List<T>();

        public void Delete(T a)
        {
            l.Remove(a);
        }

        public List<T> Get()
        {
            return l;
        }

        public void Insert(List<T> a)
        {
            l.AddRange(a);
            Console.WriteLine("Inserted");
        }

        //public abstract void Update(T a);
        
    }
}
