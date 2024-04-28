using HotelManagement.Domain.Common.Models;
using HotelManagement.Domain.ReservationAggregate.ValueObjects;
using HotelManagement.Domain.RoomAggregate.Entities;
using HotelManagement.Domain.RoomAggregate.ValueObjects;

namespace HotelManagement.Domain.RoomAggregate
{
    public sealed class Room : AggregateRoot<RoomId, Guid>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public float Price { get; private set; }
        public int Capacity { get; private set; }
        public BedroomType BedroomType { get; private set; }
        private readonly List<ReservationId> _reservations = new List<ReservationId>();
        private readonly List<CleaningHistory> _cleaningHistories = new List<CleaningHistory>();
        public IReadOnlyList<ReservationId> ReservationIds => _reservations.AsReadOnly();
        public IReadOnlyList<CleaningHistory> CleaningHistories => _cleaningHistories.AsReadOnly();

        private Room(
            RoomId roomId,
            string name,
            string description,
            float price,
            int capacity,
            BedroomType bedroomType,
            List<ReservationId> reservations,
            List<CleaningHistory> cleaningHistories)
            : base(roomId)
        {
            Name = name;
            Description = description;
            Price = price;
            Capacity = capacity;
            BedroomType = bedroomType;
            _reservations = reservations;
            _cleaningHistories = cleaningHistories;
        }

        public static Room Create(
            string name,
            string description,
            float price,
            int capacity,
            BedroomType bedroomType,
            List<ReservationId>? reservations = null,
            List<CleaningHistory>? cleaningHistories = null)
        {
            return new Room(
                RoomId.CreateUnique(),
                name,
                description,
                price,
                capacity,
                bedroomType,
                reservations ?? new(),
                cleaningHistories ?? new()
                );
        }

        public void AddReservationId(ReservationId reservationId){
            _reservations.Add(reservationId);
        }

#pragma warning disable CS8618
    private Room()
    {
    }
#pragma warning restore CS8618
    }
}