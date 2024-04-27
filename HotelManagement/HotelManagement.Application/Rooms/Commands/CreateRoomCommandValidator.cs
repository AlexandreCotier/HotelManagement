using FluentValidation;

namespace HotelManagement.Application.Rooms.Commands;

public class CreateRoomCommandValidator : AbstractValidator<CreateRoomCommand>{
    public CreateRoomCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Price).NotEmpty();
        RuleFor(x => x.Capacity).NotEmpty();
        RuleFor(x => x.BedroomType).NotEmpty();
    }
}