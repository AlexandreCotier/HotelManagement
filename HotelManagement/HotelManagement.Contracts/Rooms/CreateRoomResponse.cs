namespace HotelManagement.Contracts.Rooms;

public record CreateRoomResponse(
    string Name,
    string Description,
    float Price,
    int Capacity,
    string BedroomType
);