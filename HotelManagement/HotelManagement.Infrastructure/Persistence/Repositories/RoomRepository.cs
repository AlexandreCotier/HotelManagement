using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.RoomAggregate;
using HotelManagement.Domain.RoomAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;

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

    public  async Task<Room?> GetByIdAsync(RoomId roomId)
    {
        return await _dbContext.Rooms.FirstOrDefaultAsync(room => room.Id == roomId);
    }

    public async Task UpdateAsync(Room room)
    {
        _dbContext.Rooms.Update(room);
        await _dbContext.SaveChangesAsync();
    }
}