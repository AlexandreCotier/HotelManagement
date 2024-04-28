using HotelManagement.Domain.UserAggregate;

namespace HotelManagement.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}