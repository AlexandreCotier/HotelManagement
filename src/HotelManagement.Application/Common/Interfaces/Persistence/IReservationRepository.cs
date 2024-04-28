using HotelManagement.Domain.ReservationAggregate;

namespace HotelManagement.Application.Common.Interfaces.Persistence;

public interface IReservationRepository{
        void Add(Reservation reservation);

        Task AddAsync(Reservation reservation);
}