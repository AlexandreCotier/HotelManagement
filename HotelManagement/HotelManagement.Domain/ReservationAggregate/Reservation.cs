using HotelManagement.Domain.BillAggregate.ValueObjects;
using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.CustomerAggregate.ValueObjects;
using HotelManagement.Domain.ReservationAggregate.Events;
using HotelManagement.Domain.ReservationAggregate.ValueObjects;
using HotelManagement.Domain.RoomAggregate.ValueObjects;

namespace HotelManagement.Domain.ReservationAggregate
{
    public sealed class Reservation : AggregateRoot<ReservationId, Guid>
    {

        public CustomerId CustomerId { get; private set; }
        public RoomId RoomId { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public int NumberOfGuests { get; private set; }

        private Reservation(
            ReservationId reservationId,
            CustomerId customerId,
            RoomId roomId,
            DateTime startDateTime,
            DateTime endDateTime,
            int numberOfGuests
        ) : base(reservationId)
        {
            CustomerId = customerId;
            RoomId = roomId;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            NumberOfGuests = numberOfGuests;
        }

        public static Reservation Create(
            CustomerId customerId,
            RoomId roomId,
            DateTime startDateTime,
            DateTime endDateTime,
            int numberOfGuests
        )
        {
            var reservation = new Reservation(
                ReservationId.CreateUnique(),
                customerId,
                roomId,
                startDateTime,
                endDateTime,
                numberOfGuests
            );

            reservation.AddDomainEvent(new ReservationCreated(reservation));

            return reservation;
        }

#pragma warning disable CS8618
        private Reservation()
        {
        }
#pragma warning restore CS8618
    }
}