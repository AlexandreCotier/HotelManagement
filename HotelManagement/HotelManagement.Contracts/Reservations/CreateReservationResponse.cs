namespace HotelManagement.Contracts.Reservations;

public record CreateReservationResponse(
    string CustomerId,
    string RoomId,
    DateTime StartDateTime,
    DateTime EndDateTime,
    int NumberOfGuests
);