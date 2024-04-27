using ErrorOr;
using HotelManagement.Domain.RoomAggregate;
using MediatR;

namespace HotelManagement.Application.Rooms.Commands;
public record CreateRoomCommand(
    string Name,
    string Description,
    float Price,
    int Capacity,
    string BedroomType
) : IRequest<ErrorOr<Room>>;