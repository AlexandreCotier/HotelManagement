using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.RoomAggregate.ValueObjects
{
    public sealed class RoomStatusId : AggregateRootId<Guid>
    {
        private RoomStatusId(Guid value) : base(value)
        {
        }

        public static RoomStatusId CreateUnique()
        {
            return new RoomStatusId(Guid.NewGuid());
        }

        public static RoomStatusId Create(Guid userId)
        {
            return new RoomStatusId(userId);
        }
    }
}