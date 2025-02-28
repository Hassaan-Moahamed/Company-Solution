using IKEA.DAL.Models.Department;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.presistance.Data.Configirations.Departments
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);

            builder.Property(D => D.Name).HasColumnType("varchar(50)" ).IsRequired();

            builder.Property(D => D.Code).HasColumnType("varchar(50)").IsRequired();

            builder.Property(D => D.CreartedOn).HasDefaultValueSql("GETDATE()");

            builder.Property(D => D.LastModificationOn).HasDefaultValueSql("GETDATE()");
        }
    }
}
