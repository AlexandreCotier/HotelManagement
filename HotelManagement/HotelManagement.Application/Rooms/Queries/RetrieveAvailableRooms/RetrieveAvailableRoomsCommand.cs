using ErrorOr;
using HotelManagement.Domain.RoomAggregate;
using MediatR;

namespace HotelManagement.Application.Rooms.Queries.RetrieveAvailableRooms;

public record RetrieveAvailableRoomsCommand(DateTime Day) : IRequest<ErrorOr<List<Room>>>;