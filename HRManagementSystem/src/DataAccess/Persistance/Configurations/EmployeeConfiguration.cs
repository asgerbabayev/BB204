using HRManagementSystem.Data.Entities;
using JwtExample.Data.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtExample.Data.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.BaseEntityConfigure();
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Salary).HasDefaultValue(0).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(x => x.ProfessionId).IsRequired();
        builder.Property(x => x.DepartmentId).IsRequired();
        builder.HasOne(x => x.Profession).
            WithMany(x => x.Employees).
            HasForeignKey(x => x.ProfessionId);
        builder.HasOne(x => x.Department).
            WithMany(x => x.Employees).
            HasForeignKey(x => x.DepartmentId);
    }
}