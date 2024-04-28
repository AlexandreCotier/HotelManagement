namespace HotelManagement.Contracts.Reservations;

public record CreateReservationRequest(
    string CustomerId,
    string RoomId,
    DateTime StartDateTime,
    DateTime EndDateTime,
    int NumberOfGuests
);