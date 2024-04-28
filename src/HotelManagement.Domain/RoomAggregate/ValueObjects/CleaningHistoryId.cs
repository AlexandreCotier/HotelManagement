using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.RoomAggregate.ValueObjects
{
    public sealed class CleaningHistoryId : AggregateRootId<Guid>
    {
        private CleaningHistoryId(Guid value) : base(value)
        {
        }

        public static CleaningHistoryId CreateUnique()
        {
            return new CleaningHistoryId(Guid.NewGuid());
        }

        public static CleaningHistoryId Create(Guid userId)
        {
            return new CleaningHistoryId(userId);
        }
    }
}