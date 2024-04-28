using System.ComponentModel.Design;
using HotelManagement.Domain.RoomAggregate;
using HotelManagement.Domain.RoomAggregate.ValueObjects;

namespace HotelManagement.Application.Common.Interfaces.Persistence;

public interface IRoomRepository{
    void Add(Room room);

    Task AddAsync(Room room);

    Task<Room?> GetByIdAsync(RoomId menuId);

    Task UpdateAsync(Room room);
}