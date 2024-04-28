using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.ReservationAggregate.Events;

public record ReservationCreated(Reservation Reservation) : IDomainEvent;