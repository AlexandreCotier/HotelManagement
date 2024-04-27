using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.CustomerAggregate.ValueObjects
{
    public sealed class CustomerId : AggregateRootId<Guid>
    {
        private CustomerId(Guid value) : base(value)
        {
        }

        public static CustomerId CreateUnique()
        {
            return new CustomerId(Guid.NewGuid());
        }

        public static CustomerId Create(Guid userId)
        {
            return new CustomerId(userId);
        }
    }
}