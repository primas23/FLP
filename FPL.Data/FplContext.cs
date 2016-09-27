// <copyright file="FplContext.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data
{
    using System.Data.Entity;

    using Models.FullStats;

    /// <summary>
    /// The current application data base context
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class FplContext : DbContext
    {
        /// <summary>
        /// Gets or sets the player informations.
        /// </summary>
        /// <value>
        /// The player informations.
        /// </value>
        public IDbSet<PlayerInformation> PlayerInformations { get; set; }

        /// <summary>
        /// Gets or sets the explain fixtures.
        /// </summary>
        /// <value>
        /// The explain fixtures.
        /// </value>
        public IDbSet<ExplainFixture> ExplainFixtures { get; set; }

        /// <summary>
        /// Gets or sets the fixtures summaries.
        /// </summary>
        /// <value>
        /// The fixtures summaries.
        /// </value>
        public IDbSet<FixturesSummary> FixturesSummaries { get; set; }
    }
}
