using HotelManagement.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace HotelManagement.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;