using HotelManagement.Application.Common.Interfaces.Services;

namespace HotelManagement.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}