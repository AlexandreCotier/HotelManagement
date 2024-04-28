# HotelManagement API

- [HotelManagement API](#hotelmanagement-api)
  - [Room](#room)
    - [AddRoom](#addroom)
      - [AddRoom Request](#addroom-request)
      - [AddRoom Response](#addroom-response)

## Room

### AddRoom

#### AddRoom Request

```js
POST /rooms
```

```json
{
    "name" : "Chambre 21",
    "description" : "Chambre simple pour une personne tristement célibataire",
    "price" : 100,
    "capacity" : 1,
    "bedroomType" : "Simple"
}
```

#### AddRoom Response

```js
200 OK
```

```json
{
    "name" : "Chambre 21",
    "description" : "Chambre simple pour une personne tristement célibataire",
    "price" : 100,
    "capacity" : 1,
    "bedroomType" : "Simple"
}
```