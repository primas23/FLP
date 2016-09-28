// <copyright file="IFantasyPremierLeagueId.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Common.Contracts
{
    /// <summary>
    /// Interface that ensures that the object implementing it has the FantasyPremierLeagueId property
    /// </summary>
    public interface IFantasyPremierLeagueId
    {
        /// <summary>
        /// Gets or sets the fantasy premier league identifier.
        /// </summary>
        /// <value>
        /// The fantasy premier league identifier.
        /// </value>
        int FantasyPremierLeagueId { get; set; }
    }
}
