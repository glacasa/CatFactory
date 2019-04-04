﻿namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a default constraint
    /// </summary>
    public class Default : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Default"/> class
        /// </summary>
        public Default()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Default"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public Default(params string[] key)
            : base(key)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the value for default constraint
        /// </summary>
        public string Value { get; set; }

        #endregion
    }
}
