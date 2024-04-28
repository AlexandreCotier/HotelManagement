using HotelManagement.Domain.CleanerAggregate.ValueObjects;
using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.RoomAggregate.ValueObjects;

namespace HotelManagement.Domain.RoomAggregate.Entities;
public sealed class CleaningHistory : Entity<CleaningHistoryId>{
    public CleaningStatus CleaningStatus { get; private set; }
    public CleanerId CleanerId { get; private set; }
    public DateTime CleanDate { get; private set;}

    private CleaningHistory(
        CleaningHistoryId cleaningHistoryId,
        CleaningStatus cleaningStatus,
        CleanerId cleanerId,
        DateTime cleanDate) : base(cleaningHistoryId)
    {
        CleaningStatus = cleaningStatus;
        CleanerId = cleanerId;
        CleanDate = cleanDate;
    }

    public static CleaningHistory Create(
        CleaningStatus cleaningStatus,
        CleanerId cleanerId){
            return new CleaningHistory(
                CleaningHistoryId.CreateUnique(),
                cleaningStatus,
                cleanerId,
                DateTime.UtcNow);
        }

#pragma warning disable CS8618
    private CleaningHistory()
    {
    }
#pragma warning restore CS8618
}