using MediatR;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Application.Rooms.Commands;
using HotelManagement.Contracts.Rooms;

namespace HotelManagement.Api.Controllers;

[Route("rooms")]
public class RoomController : ApiController{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public RoomController(IMapper mapper, ISender sender)
    {
        _mapper = mapper;
        _mediator = sender;
    }


    [HttpPost]
    public async Task<IActionResult> CreateRoom(CreateRoomRequest request)
    {
        var command = _mapper.Map<CreateRoomCommand>(request);

        var createRoomResult = await _mediator.Send(command);

        return createRoomResult.Match(
            room => Ok(_mapper.Map<CreateRoomResponse>(room)),
            errors => Problem(errors));
    }
}