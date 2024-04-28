using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.CleanerAggregate.ValueObjects
{
    public sealed class CleanerId : AggregateRootId<Guid>
    {
        private CleanerId(Guid value) : base(value)
        {
        }

        public static CleanerId CreateUnique()
        {
            return new CleanerId(Guid.NewGuid());
        }

        public static CleanerId Create(Guid userId)
        {
            return new CleanerId(userId);
        }
    }
}