using HotelManagement.Domain.RoomAggregate;
using HotelManagement.Domain.RoomAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Persistence.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        ConfigureRoomTable(builder);
        ConfigureReservationIdsTable(builder);
    }

    private void ConfigureRoomTable(EntityTypeBuilder<Room> builder)
    {
        builder.ToTable("Rooms");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => RoomId.Create(value));

        builder.Property(x => x.Name)
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .HasMaxLength(100);

        builder.OwnsOne(x => x.RoomStatus);
    }

    private void ConfigureReservationIdsTable(EntityTypeBuilder<Room> builder)
    {
        builder.OwnsMany(x => x.ReservationIds, rib => {
            rib.ToTable("ReservationIds");

            rib.WithOwner().HasForeignKey("RoomId");

            rib.HasKey("Id");

            rib.Property(ri => ri.Value)
                .HasColumnName("ReservationId");
        });

        builder.Metadata.FindNavigation(nameof(Room.ReservationIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Field);
    }
}