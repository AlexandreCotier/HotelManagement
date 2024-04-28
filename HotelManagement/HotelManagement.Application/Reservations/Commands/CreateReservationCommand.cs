using ErrorOr;
using HotelManagement.Domain.ReservationAggregate;
using MediatR;

namespace HotelManagement.Application.Reservations.Commands;

public record CreateReservationCommand (
    string CustomerId,
    string RoomId,
    DateTime StartDateTime,
    DateTime EndDateTime,
    int NumberOfGuests
) : IRequest<ErrorOr<Reservation>>;