using Backend.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infrastructure.ReserveMapping
{
    public class ReserveClassMap : IEntityTypeConfiguration<Reserve>
    {
        public void Configure(EntityTypeBuilder<Reserve> builder)
        {
            builder.ToTable("Reserve", "dbo", t =>
            {
                t.HasCheckConstraint("CK_resourceType",
                    "resourceType IN ('room','vehicle','equipment')");
                t.HasCheckConstraint("CK_DateTimeStart",
                    "DateTimeStart >= '08:00:00' AND DateTimeStart <= '18:00:00'");
                t.HasCheckConstraint("CK_hourDuration",
                    "hourDuration BETWEEN 1 AND 8");
            });

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired(true);

            builder.Property(x => x.ResourceType)
                .HasColumnName("resourceType")
                .IsRequired(true);

            builder.Property(x => x.ResponsibleName)
                .HasColumnName("responsibleName")
                .IsRequired(true);

            builder.Property(x => x.DateTimeStart)
                .HasColumnName("DateTimeStart")
                .IsRequired(true);

            builder.Property(x => x.HourDuration)
                .HasColumnName("hourDuration")
                .IsRequired(true);

        }
    }
}
