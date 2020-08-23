using System.Linq;
using MyShopDemo.Core.Models;

namespace MyShopDemo.Core.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Commit();
        void Insert(T t);
        void Update(T t);   
        T Find(string Id);
        IQueryable<T> Collection();
        void Delete(string Id);
    }
}