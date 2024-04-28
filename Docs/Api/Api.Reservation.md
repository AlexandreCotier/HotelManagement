# HotelManagement API

- [HotelManagement API](#hotelmanagement-api)
  - [Reservation](#reservation)
    - [AddReservation](#addreservation)
      - [AddReservation Request](#addreservation-request)
      - [AddReservation Response](#addreservation-response)

## Reservation

### AddReservation

#### AddReservation Request

```js
POST /reservations
```

```json
{
    "customerId": "Customer_f902c93d-9339-44b2-ba27-6cf42e40faa7",
    "roomId": "2f044da2-0cd8-4670-822d-506366f814ea",
    "startDateTime" : "2024-04-10T00:00:00.0000000Z",
    "endDateTime": "2024-04-12T00:00:00.0000000Z",
    "numberOfGuests": 2
}
```

#### AddReservation Response

```js
200 OK
```

```json
{
    "customerId": "Customer_f902c93d-9339-44b2-ba27-6cf42e40faa7",
    "roomId": "2f044da2-0cd8-4670-822d-506366f814ea",
    "startDateTime" : "2024-04-10T00:00:00.0000000Z",
    "endDateTime": "2024-04-12T00:00:00.0000000Z",
    "numberOfGuests": 2
}
```