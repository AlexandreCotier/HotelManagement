using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.RoomAggregate;

namespace HotelManagement.Infrastructure.Persistence.Repositories;

public class RoomRepository : IRoomRepository{
    private readonly HotelManagementDbContext _dbContext;

    public RoomRepository(HotelManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Room room){
        _dbContext.Add(room);
        _dbContext.SaveChanges();
    }

    public async Task AddAsync(Room room)
    {
        _dbContext.Add(room);
        await _dbContext.SaveChangesAsync();
    }
}