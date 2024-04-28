using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.ReceptionistAggregate.ValueObjects
{
    public sealed class ReceptionistId : AggregateRootId<Guid>
    {
        private ReceptionistId(Guid value) : base(value)
        {
        }

        public static ReceptionistId CreateUnique()
        {
            return new ReceptionistId(Guid.NewGuid());
        }

        public static ReceptionistId Create(Guid userId)
        {
            return new ReceptionistId(userId);
        }
    }
}