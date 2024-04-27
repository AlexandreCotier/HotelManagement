using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.ReservationAggregate.ValueObjects;

namespace HotelManagement.Reservation.BillAggregate
{
    public sealed class Reservation : AggregateRoot<ReservationId, Guid>{

    }
}