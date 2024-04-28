using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.BillAggregate.ValueObjects
{
    public sealed class InvoiceId : AggregateRootId<Guid>
    {
        private InvoiceId(Guid value) : base(value)
        {
        }

        public static InvoiceId CreateUnique()
        {
            return new InvoiceId(Guid.NewGuid());
        }

        public static InvoiceId Create(Guid userId)
        {
            return new InvoiceId(userId);
        }
    }
}