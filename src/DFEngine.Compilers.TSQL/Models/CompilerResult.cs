﻿using System.Collections.Generic;

namespace DFEngine.Compilers.TSQL.Models
{
    /// <summary>
    /// Represents the final result of the SQL compiler
    /// </summary>
    public class CompilerResult
    {
        /// <summary>
        /// Contains all Data Manipulations(INSERT, UPDATE, DELETE, etc.) found in the SQL
        /// </summary>
        public List<DataManipulation> DataManipulations { get; internal set; }

        /// <summary>
        /// Contains all Data Queries that are not inner statements
        /// </summary>
        public List<Expression> DataQueries { get; internal set; }
    }
}
