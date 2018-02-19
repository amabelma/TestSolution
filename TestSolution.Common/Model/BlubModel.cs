using TestSolution.Common.Enum;
using TestSolution.Common.Utility;
using System;

namespace TestSolution.Common.Model
{
    public sealed class BlubModel
    {
        public BlubModel(
            long id,
            DateTime dateAcquired,
            BlubItemCategory itemCategory,
            DateTime dateRemoved,
            int? valueUponAcquisition,
            int? valueUponRemoval,
            string acquiredBy,
            string notes)
            {
                Guard.AgainstInvalidId(id, nameof(id));

                this.Id = id;
                this.DateAcquired = dateAcquired;
                this.ItemCategory = itemCategory;
                this.DateRemoved = dateRemoved;
                this.ValueUponAcquisition = valueUponAcquisition;
                this.ValueUponRemoval = valueUponRemoval;
                this.AcquiredBy = acquiredBy;
                this.Notes = notes;
            }

            public long Id { get; private set; }
            public DateTime DateAcquired { get; private set; }

            public BlubItemCategory ItemCategory { get; private set; }
            public DateTime DateRemoved { get; private set; }
            public int? ValueUponAcquisition { get; private set; }
            public int? ValueUponRemoval { get; private set; }
            public string AcquiredBy { get; private set; }
            public string Notes { get; private set; }
    }
}