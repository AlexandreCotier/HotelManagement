using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.UserAggregate;

namespace HotelManagement.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly HotelManagementDbContext _dbContext;

    public UserRepository(HotelManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(User user)
    {
        _dbContext.Add(user);

        _dbContext.SaveChanges();
    }

    public User? GetUserByEmail(string email)
    {
        return _dbContext.Users
            .SingleOrDefault(u => u.Email == email);
    }
}