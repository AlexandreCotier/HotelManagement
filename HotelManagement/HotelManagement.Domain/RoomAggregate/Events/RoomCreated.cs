using HotelManagement.Domain.Common.Models;

namespace HotelManagement.Domain.RoomAggregate.Events;

public record RoomCreated(Room room) : IDomainEvent;