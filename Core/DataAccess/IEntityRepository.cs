using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //T'yi sınırlandırmak gerekiyor belirtilen şeyleri filtrelemek için 
    //Generic constraint == generic kısıt demek.
    //class dediğimiz zaman referans tip olabilir demek herhangi bir class yazabiliyor bu yüzden kısıtlamaya devam etmeliyiz
    //IEntity olabilir ya da implemente eden bir nesne olabilir demek IEntity olmaması gerekiyor bu yüzden kısıtlamaya devam ediyoruz
    //newlenebilir olmalı Ientity newlenemediği için yeterli olur

    public interface IEntityRepository<T>where T : class,IEntity,new()
    {
        //Expression lamda gibi kullandığımız şartları kullanmamız için gereken syntax
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
