using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.UserAggregate.ValueObjects;

namespace HotelManagement.Domain.CustomerAggregate.ValueObjects
{
    public sealed class CustomerId : AggregateRootId<string>
    {
        private CustomerId(string value) : base(value)
        {
        }

        public static CustomerId Create(string hostId)
        {
            return new CustomerId(hostId);
        }

        public static CustomerId Create(UserId userId)
        {
            return new CustomerId($"Customer_{userId.Value}");
        }
    }
}