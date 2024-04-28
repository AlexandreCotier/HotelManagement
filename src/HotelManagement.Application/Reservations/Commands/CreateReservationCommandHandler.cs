using ErrorOr;
using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.CustomerAggregate.ValueObjects;
using HotelManagement.Domain.ReservationAggregate;
using HotelManagement.Domain.RoomAggregate.ValueObjects;
using MediatR;

namespace HotelManagement.Application.Reservations.Commands;

public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, ErrorOr<Reservation>>
{
    private readonly IReservationRepository _reservationRepository;
    public CreateReservationCommandHandler(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public async Task<ErrorOr<Reservation>> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
         var reservation = Reservation.Create(
            CustomerId.Create(request.CustomerId),
            RoomId.Create(request.RoomId),
            request.StartDateTime,
            request.EndDateTime,
            request.NumberOfGuests
        );

        await _reservationRepository.AddAsync(reservation);

        return reservation;
    }
}
