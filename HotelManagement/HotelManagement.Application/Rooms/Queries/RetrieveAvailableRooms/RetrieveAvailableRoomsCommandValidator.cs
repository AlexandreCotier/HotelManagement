using FluentValidation;
using HotelManagement.Application.Rooms.Queries.RetrieveAvailableRooms;

public class RetrieveAvailableRoomsCommandValidator : AbstractValidator<RetrieveAvailableRoomsCommand>{
    public RetrieveAvailableRoomsCommandValidator()
    {
        RuleFor(x => x.Day).NotEmpty();
    }
}