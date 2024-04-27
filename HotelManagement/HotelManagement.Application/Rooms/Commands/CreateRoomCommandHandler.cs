using System.ComponentModel.Design;
using ErrorOr;
using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.RoomAggregate;
using HotelManagement.Domain.RoomAggregate.Entities;
using MediatR;

namespace HotelManagement.Application.Rooms.Commands;

public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, ErrorOr<Room>>
{
    private readonly IRoomRepository _roomRepository;
    public CreateRoomCommandHandler(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task<ErrorOr<Room>> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        var bedroomType = BedroomType.Simple;

        if(request.BedroomType == "Double"){
            bedroomType = BedroomType.Double;
        }

        if(request.BedroomType == "Suite"){
            bedroomType = BedroomType.Suite;
        }

        var room = Room.Create(
            request.Name,
            request.Description,
            request.Price,
            request.Capacity,
            bedroomType
        );

        await _roomRepository.AddAsync(room);

        return room;
    }
}