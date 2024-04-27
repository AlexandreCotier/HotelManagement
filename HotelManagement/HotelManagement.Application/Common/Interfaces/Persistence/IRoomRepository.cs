using System.ComponentModel.Design;
using HotelManagement.Domain.RoomAggregate;

namespace HotelManagement.Application.Common.Interfaces.Persistence;

public interface IRoomRepository{
    void Add(Room room);

    Task AddAsync(Room room);
}