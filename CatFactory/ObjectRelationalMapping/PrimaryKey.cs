﻿namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a primary key constraint
    /// </summary>
    public class PrimaryKey : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        public PrimaryKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public PrimaryKey(params string[] key)
            : base(key)
        {
        }

        #endregion
    }
}
