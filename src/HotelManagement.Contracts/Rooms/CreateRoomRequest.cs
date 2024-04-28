namespace HotelManagement.Contracts.Rooms;

public record CreateRoomRequest(
    string Name,
    string Description,
    float Price,
    int Capacity,
    string BedroomType
);