﻿namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents an unique constraint
    /// </summary>
    public class Unique : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Unique"/> class
        /// </summary>
        public Unique()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Unique"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public Unique(params string[] key)
            : base(key)
        {
        }

        #endregion
    }
}
