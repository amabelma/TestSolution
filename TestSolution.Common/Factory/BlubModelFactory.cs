using TestSolution.Common.Model;
using TestSolution.Common.Enum;
using System;

namespace TestSolution.Common.Factory
{
    public static class BlubModelFactory
    {
        public static BlubModel CreateNewBlubModel(
            long id,
            DateTime dateAcquired,
            BlubItemCategory itemCategory,
            DateTime dateRemoved,
            int? valueUponAcquisition,
            int? valueUponRemoval,
            string acquiredBy,
            string notes)
        {
            return new BlubModel(
                id,
                dateAcquired,
                itemCategory,
                dateRemoved,
                valueUponAcquisition,
                valueUponRemoval,
                acquiredBy,
                notes);
        }
    }
}