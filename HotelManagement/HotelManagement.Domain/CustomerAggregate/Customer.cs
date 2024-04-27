using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.CustomerAggregate.ValueObjects;

namespace HotelManagement.Domain.CustomerAggregate
{
    public sealed class Customer : AggregateRoot<CustomerId, Guid>
    {

    }
}