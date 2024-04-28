using HotelManagement.Domain.CleanerAggregate.ValueObjects;
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
        ConfigureCleaningHistoriesTable(builder);
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
    }

    private void ConfigureCleaningHistoriesTable(EntityTypeBuilder<Room> builder)
    {
        builder.OwnsMany(x => x.CleaningHistories, chb => {
            chb.ToTable("CleaningHistories");

            chb.WithOwner().HasForeignKey("RoomId");

            chb.HasKey("Id");

            chb.Property(ch => ch.Id)
                .HasColumnName("CleaningHistoryId")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => CleaningHistoryId.Create(value));

            chb.Property(ch => ch.CleanerId)
                .HasColumnName("CleanerId")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => CleanerId.Create(value));
        });

        builder.Metadata.FindNavigation(nameof(Room.ReservationIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Property);
    }

    private void ConfigureReservationIdsTable(EntityTypeBuilder<Room> builder)
    {
        builder.OwnsMany(x => x.ReservationIds, rib => {
            rib.ToTable("ReservationIds");

            rib.WithOwner().HasForeignKey("RoomId");

            rib.HasKey("Id");

            rib.Property(ri => ri.Value)
                .HasColumnName("ReservationId")
                .ValueGeneratedNever();
        });

        builder.Metadata.FindNavigation(nameof(Room.ReservationIds))!
            .SetPropertyAccessMode(PropertyAccessMode.Property);
    }
}