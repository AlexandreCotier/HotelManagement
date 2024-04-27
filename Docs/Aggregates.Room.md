# Domain Aggregates

## Room

***

```json
{
    "id" : "00000000-0000-0000-0000-000000000000",
    "name" : "Chambre 210",
    "description" : "Chambre basique pour deux personnes",
    "price" : 200,
    "capacity" : 2,
    "bedroomType" : "Double", // Simple, Suite
    "reservationIds" : [
        { "value" : "00000000-0000-0000-0000-000000000000"}
    ],
    "roomStatus" : {
        "id" : "RoomStatus_00000000-0000-0000-0000-000000000000",
        "cleaningStatus" : "Cleaned", //NotInspected
        "cleanerId":"RoomStatus_00000000-0000-0000-0000-000000000000"
    }
}

```
