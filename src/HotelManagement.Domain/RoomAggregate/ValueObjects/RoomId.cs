using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.RoomAggregate.ValueObjects
{
    public sealed class RoomId : AggregateRootId<Guid>
    {
        private RoomId(Guid value) : base(value)
        {
        }

        public static RoomId CreateUnique()
        {
            return new RoomId(Guid.NewGuid());
        }

        public static RoomId Create(string roomId)
        {
            return new RoomId(Guid.Parse(roomId));
        }

        public static RoomId Create(Guid roomId)
        {
            return new RoomId(roomId);
        }
    }
}