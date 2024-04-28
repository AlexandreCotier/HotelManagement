using HotelManagement.Application.Authentication.Commands.Register;
using HotelManagement.Application.Authentication.Common;
using HotelManagement.Application.Authentication.Queries.Login;
using HotelManagement.Contracts.Authentication;
using Mapster;

namespace HotelManagement.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Id, src => src.User.Id.Value.ToString())
            .Map(dest => dest, src => src.User);
    }
}