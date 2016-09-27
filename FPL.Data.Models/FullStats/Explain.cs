// <copyright file="Explain.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Explain details and fixture class for the player points
    /// </summary>
    public class Explain : FullStatsBase
    {
        /// <summary>
        /// Gets or sets the explain details.
        /// </summary>
        /// <value>
        /// The explain details.
        /// </value>
        [JsonProperty("explainDetails")]
        public ExplainDetails ExplainDetails { get; set; }

        /// <summary>
        /// Gets or sets the explain fixture.
        /// </summary>
        /// <value>
        /// The explain fixture.
        /// </value>
        [JsonProperty("fixtureExplain")]
        public ExplainFixture ExplainFixture { get; set; }
    }
}