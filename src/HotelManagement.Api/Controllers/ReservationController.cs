using HotelManagement.Application.Reservations.Commands;
using HotelManagement.Contracts.Reservations;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Controllers;

[Route("reservations")]
public class ReservationController : ApiController{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public ReservationController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreateReservation(CreateReservationRequest request)
    {
        var command = _mapper.Map<CreateReservationCommand>(request);

        var createReservationResult = await _mediator.Send(command);

        return createReservationResult.Match(
            reservation => Ok(_mapper.Map<CreateReservationResponse>(reservation)),
            errors => Problem(errors));
    }
}