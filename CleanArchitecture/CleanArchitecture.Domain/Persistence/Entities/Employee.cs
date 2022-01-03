using System;
using System.Collections.Generic;

namespace CleanArchitecture.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'Employee'.
    /// </summary>
    public partial class Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'Id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Id'.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Birthday'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Birthday'.
        /// </value>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FullName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FullName'.
        /// </value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedUsername'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedUsername'.
        /// </value>
        public string CreatedUsername { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedFullName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedFullName'.
        /// </value>
        public string CreatedFullName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CreatedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CreatedDate'.
        /// </value>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedUsername'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedUsername'.
        /// </value>
        public string ModifiedUsername { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModdifiedFullName'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModdifiedFullName'.
        /// </value>
        public string ModdifiedFullName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ModifiedDate'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ModifiedDate'.
        /// </value>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Status'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Status'.
        /// </value>
        public int? Status { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
