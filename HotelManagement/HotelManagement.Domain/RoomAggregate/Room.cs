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
        public IReadOnlyList<ReservationId> ReservationIds => _reservations.AsReadOnly();
        public RoomStatus RoomStatus { get; private set; }

        private Room(
            RoomId roomId,
            string name,
            string description,
            float price,
            int capacity,
            BedroomType bedroomType,
            List<ReservationId> reservations,
            RoomStatus roomStatus)
            : base(roomId)
        {
            Name = name;
            Description = description;
            Price = price;
            Capacity = capacity;
            BedroomType = bedroomType;
            _reservations = reservations;
            RoomStatus = roomStatus;
        }

        public static Room Create(
            string name,
            string description,
            float price,
            int capacity,
            BedroomType bedroomType,
            List<ReservationId>? reservations = null)
        {
            return new Room(
                RoomId.CreateUnique(),
                name,
                description,
                price,
                capacity,
                bedroomType,
                reservations,
                RoomStatus.Create(CleaningStatus.NotInspected)
                );
        }

        private Room()
        {
        }
    }
}