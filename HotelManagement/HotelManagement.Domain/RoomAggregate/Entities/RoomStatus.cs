using HotelManagement.Domain.CleanerAggregate.ValueObjects;
using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.RoomAggregate.ValueObjects;

namespace HotelManagement.Domain.RoomAggregate.Entities;
public sealed class RoomStatus : Entity<RoomStatusId>{
    public CleaningStatus CleaningStatus { get; private set; }
    public CleanerId CleanerId { get; private set; }

    private RoomStatus(
        RoomStatusId roomStatusId,
        CleaningStatus cleaningStatus,
        CleanerId cleanerId) : base(roomStatusId)
    {
        CleaningStatus = cleaningStatus;
        CleanerId = cleanerId;
    }

    public static RoomStatus Create(
        CleaningStatus cleaningStatus,
        CleanerId? cleanerId = null){
            return new RoomStatus(
                RoomStatusId.CreateUnique(),
                cleaningStatus,
                cleanerId);
        }

    private RoomStatus()
    {
    }
}