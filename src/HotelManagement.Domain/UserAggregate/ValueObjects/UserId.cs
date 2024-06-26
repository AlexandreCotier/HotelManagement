using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.UserAggregate.ValueObjects
{
    public sealed class UserId : AggregateRootId<Guid>
    {
        private UserId(Guid value) : base(value)
        {
        }

        public static UserId CreateUnique()
        {
            return new UserId(Guid.NewGuid());
        }

        public static UserId Create(Guid userId)
        {
            return new UserId(userId);
        }
    }
}