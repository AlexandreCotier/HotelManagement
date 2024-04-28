using ErrorOr;
using HotelManagement.Domain.RoomAggregate;
using MediatR;

namespace HotelManagement.Application.Rooms.Queries.RetrieveAvailableRooms
{
    public class RetrieveAvailableRoomsCommandHandler : IRequestHandler<RetrieveAvailableRoomsCommand, ErrorOr<List<Room>>>{
        public RetrieveAvailableRoomsCommandHandler()
        {
        }

        public async Task<ErrorOr<List<Room>>> Handle(RetrieveAvailableRoomsCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            return new List<Room>();
        }
    }
}