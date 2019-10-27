﻿using System;
using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the first result set for object (database object)
    /// </summary>
    [DebuggerDisplay("ColumnOrdinal={ColumnOrdinal}, Name={Name}, IsNullable={IsNullable}, SystemTypeName={SystemTypeName}")]
    [Obsolete("This is a model class for SQL Server")]
    public class FirstResultSetForObject
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="FirstResultSetForObject"/> class
        /// </summary>
        public FirstResultSetForObject()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the column ordinal
        /// </summary>
        public int ColumnOrdinal { get; set; }

        /// <summary>
        /// Gets or sets the name for result
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if column is nullable
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the system type (database type) name
        /// </summary>
        public string SystemTypeName { get; set; }

        #endregion
    }
}
