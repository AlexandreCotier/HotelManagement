using HotelManagement.Api.Common.Errors;
using HotelManagement.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HotelManagement.Api;

public static class DependencyInjection {
    public static IServiceCollection AddPresentation(this IServiceCollection services){
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, HotelManagementProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}