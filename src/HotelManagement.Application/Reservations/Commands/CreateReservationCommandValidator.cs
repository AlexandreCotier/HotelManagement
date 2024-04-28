using FluentValidation;
using HotelManagement.Application.Rooms.Commands;

namespace HotelManagement.Application.Reservations.Commands;

public class CreateReservationCommandValidator : AbstractValidator<CreateReservationCommand>{
    public CreateReservationCommandValidator()
    {
        RuleFor(x => x.CustomerId).NotEmpty();
        RuleFor(x => x.RoomId).NotEmpty();
        RuleFor(x => x.StartDateTime).NotEmpty();
        RuleFor(x => x.EndDateTime).NotEmpty();
        RuleFor(x => x.NumberOfGuests).NotEmpty();
    }
}