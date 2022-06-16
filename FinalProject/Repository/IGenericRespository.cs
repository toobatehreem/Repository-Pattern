using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Model;

namespace FinalProject.Repository
{
    public interface IGenericRespository<T>
    {
        List<T> Get();
        void Insert(List<T> a);
       // void Update(T a);
        void Delete(T a);


    }
}
