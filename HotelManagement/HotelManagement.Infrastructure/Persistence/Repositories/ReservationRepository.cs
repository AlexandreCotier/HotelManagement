using HotelManagement.Application.Common.Interfaces.Persistence;
using HotelManagement.Domain.ReservationAggregate;

namespace HotelManagement.Infrastructure.Persistence.Repositories;

public class ReservationRepository : IReservationRepository
{
    private readonly HotelManagementDbContext _dbContext;
    public ReservationRepository(HotelManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Add(Reservation reservation){
        _dbContext.Add(reservation);
        _dbContext.SaveChanges();
    }

    public async Task AddAsync(Reservation reservation)
    {
        _dbContext.Add(reservation);
        await _dbContext.SaveChangesAsync();
    }
}