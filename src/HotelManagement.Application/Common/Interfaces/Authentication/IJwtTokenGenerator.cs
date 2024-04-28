using HotelManagement.Domain.UserAggregate;

namespace HotelManagement.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}