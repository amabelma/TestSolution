using TestSolution.Common.Model;
using System.Collections.Generic;

namespace TestSolution.Common.Repository
{
    public interface IBlubRepository
    {
        IEnumerable<BlubModel> GetAll();
        
        BlubModel Get(long id);

        void Insert(BlubModel bm);

        void Update(BlubModel bm);

        void Delete(BlubModel bm);
    }
}