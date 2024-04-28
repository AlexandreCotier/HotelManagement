using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.ReservationAggregate.Events;
using HotelManagement.Domain.ReservationAggregate.ValueObjects;
using HotelManagement.Domain.RoomAggregate;
using MediatR;

namespace HotelManagement.Application.Rooms.Events;

public class ReservationCreatedEventHandler : INotificationHandler<ReservationCreated>{
    private readonly IRoomRepository _roomRepository;

    public ReservationCreatedEventHandler(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task Handle(ReservationCreated reservationCreatedEvent, CancellationToken cancellationToken){
        if(await _roomRepository.GetByIdAsync(reservationCreatedEvent.Reservation.RoomId) is not Room room){
            throw new InvalidOperationException($"Reservation has invalid room id (reservation id: {reservationCreatedEvent.Reservation.Id}, room id: {reservationCreatedEvent.Reservation.RoomId}).");
        }

        room.AddReservationId((ReservationId)reservationCreatedEvent.Reservation.Id);

        await _roomRepository.UpdateAsync(room);
    }
}