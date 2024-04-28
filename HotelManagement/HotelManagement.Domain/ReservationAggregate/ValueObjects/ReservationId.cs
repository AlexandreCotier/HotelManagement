using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.ReservationAggregate.ValueObjects
{
    public sealed class ReservationId : AggregateRootId<Guid>
    {
        private ReservationId(Guid value) : base(value)
        {
        }

        public static ReservationId CreateUnique()
        {
            return new ReservationId(Guid.NewGuid());
        }

        public static ReservationId Create(Guid userId)
        {
            return new ReservationId(userId);
        }
    }
}