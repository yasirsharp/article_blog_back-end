using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    /// <summary>
    /// T nesnesi sınırlandırılmıştır. (ayrıca bkz: Generic Constraint)
    /// Verilebilecek T özellikleri
    /// <list type="number">  
    ///     <item> class: Referance Type </item>  
    ///     <item> IEntity - Object </item>  
    ///     <item> new(): Instance oluşturulabilecek bir nesne </item>  
    /// </list>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
