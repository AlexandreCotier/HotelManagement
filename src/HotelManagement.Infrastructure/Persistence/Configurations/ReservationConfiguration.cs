using HotelManagement.Domain.CustomerAggregate.ValueObjects;
using HotelManagement.Domain.ReservationAggregate;
using HotelManagement.Domain.ReservationAggregate.ValueObjects;
using HotelManagement.Domain.RoomAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Persistence.Configurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        ConfigureReservationTable(builder);
    }

    private void ConfigureReservationTable(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservations");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ReservationId.Create(value)
            );

        builder.Property(x => x.CustomerId)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => CustomerId.Create(value)
            );

        builder.Property(x => x.RoomId)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => RoomId.Create(value)
            );
    }
}