using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Data
{
    /// <summary>
    /// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities. 
    /// </summary>
    public partial class CleanArchitectureContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleanArchitectureContext"/> class.
        /// </summary>
        /// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CleanArchitecture.Data.Entities.Employee"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="CleanArchitecture.Data.Entities.Employee"/>.
        /// </value>
        public virtual DbSet<CleanArchitecture.Data.Entities.Employee> Employees { get; set; }

        #endregion

        /// <summary>
        /// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new CleanArchitecture.Data.Mapping.EmployeeMap());
            #endregion
        }
    }
}
