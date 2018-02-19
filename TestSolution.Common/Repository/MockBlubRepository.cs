using System;
using System.Collections.Generic;
using System.Linq;
using TestSolution.Common.Enum;
using TestSolution.Common.Model;

namespace TestSolution.Common.Repository
{
    public class MockBlubRepository: IBlubRepository
    {
        public IEnumerable<BlubModel> GetAll()
        {
            return _blub;
        }

        public BlubModel Get(long id)
        {
            return _blub.FirstOrDefault(bm => bm.Id == id);
        }

        public void Insert(BlubModel bm)
        {
            _blub.Add(bm);
        }

        public void Update(BlubModel bm)
        {
            var toEdit = _blub.FirstOrDefault(a => a.Id == bm.Id);

            _blub[_blub.IndexOf(toEdit)] = bm;
        }

        public void Delete(BlubModel bm)
        {
            throw new NotImplementedException();
        }

        private List<BlubModel> _blub = new List<BlubModel>()
        {
            new BlubModel(
                1,
                new DateTime(2018, 2, 1, 9, 0, 0),
                BlubItemCategory.ComputerComponent,
                new DateTime(2018, 2, 1, 9, 0, 0),
                50,
                30,
                "Mark Amabeli",
                "Really cool."),
            new BlubModel(
                1,
                new DateTime(2018, 2, 1, 9, 0, 0),
                BlubItemCategory.Furnature,
                new DateTime(2018, 2, 1, 9, 0, 0),
                50,
                30,
                "Mark Amabeli",
                "Really cool.")
        };
    }
}