// <copyright file="IPlayerInformation.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Common.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// This is interface for the minimum need information for the Summary to be build
    /// </summary>
    public interface IPlayerInformation
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        string LastName { get; set; }
        
        /// <summary>
        /// Gets or sets the history.
        /// </summary>
        /// <value>
        /// The history.
        /// </value>
        IList<IHistory> Histories { get; set; }
    }
}