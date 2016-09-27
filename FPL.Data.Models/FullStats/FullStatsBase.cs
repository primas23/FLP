// <copyright file="FullStatsBase.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    public class FullStatsBase : ModelBase
    {
        /// <summary>
        /// Gets or sets the player information identifier.
        /// </summary>
        /// <value>
        /// The player information identifier.
        /// </value>
        public int PlayerInformationId { get; set; }

        /// <summary>
        /// Gets or sets the player information.
        /// </summary>
        /// <value>
        /// The player information.
        /// </value>
        public virtual PlayerInformation PlayerInformation { get; set; }
    }
}
