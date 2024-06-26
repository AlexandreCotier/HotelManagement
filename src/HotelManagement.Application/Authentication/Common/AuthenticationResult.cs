using HotelManagement.Domain.UserAggregate;

namespace HotelManagement.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);