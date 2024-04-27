using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.BillAggregate.ValueObjects
{
    public sealed class BillId : AggregateRootId<Guid>
    {
        private BillId(Guid value) : base(value)
        {
        }

        public static BillId CreateUnique()
        {
            return new BillId(Guid.NewGuid());
        }

        public static BillId Create(Guid userId)
        {
            return new BillId(userId);
        }
    }
}