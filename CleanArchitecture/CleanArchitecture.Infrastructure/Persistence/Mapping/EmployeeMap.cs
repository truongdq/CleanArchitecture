using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="CleanArchitecture.Data.Entities.Employee" />
    /// </summary>
    public partial class EmployeeMap
        : IEntityTypeConfiguration<CleanArchitecture.Data.Entities.Employee>
    {
        /// <summary>
        /// Configures the entity of type <see cref="CleanArchitecture.Data.Entities.Employee" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CleanArchitecture.Data.Entities.Employee> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Employee");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Birthday)
                .HasColumnName("Birthday")
                .HasColumnType("date");

            builder.Property(t => t.FullName)
                .HasColumnName("FullName")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.CreatedUsername)
                .HasColumnName("CreatedUsername")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreatedFullName)
                .HasColumnName("CreatedFullName")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime");

            builder.Property(t => t.ModifiedUsername)
                .HasColumnName("ModifiedUsername")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ModdifiedFullName)
                .HasColumnName("ModdifiedFullName")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .HasColumnType("int(255)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="CleanArchitecture.Data.Entities.Employee" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="CleanArchitecture.Data.Entities.Employee" /></summary>
            public const string Name = "Employee";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.Birthday" /></summary>
            public const string Birthday = "Birthday";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.FullName" /></summary>
            public const string FullName = "FullName";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.CreatedUsername" /></summary>
            public const string CreatedUsername = "CreatedUsername";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.CreatedFullName" /></summary>
            public const string CreatedFullName = "CreatedFullName";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.CreatedDate" /></summary>
            public const string CreatedDate = "CreatedDate";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.ModifiedUsername" /></summary>
            public const string ModifiedUsername = "ModifiedUsername";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.ModdifiedFullName" /></summary>
            public const string ModdifiedFullName = "ModdifiedFullName";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.ModifiedDate" /></summary>
            public const string ModifiedDate = "ModifiedDate";
            /// <summary>Column Name constant for property <see cref="CleanArchitecture.Data.Entities.Employee.Status" /></summary>
            public const string Status = "Status";
        }
        #endregion
    }
}
