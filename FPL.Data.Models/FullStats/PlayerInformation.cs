// <copyright file="PlayerInformation.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// All the player information form the Fantasy Premier League
    /// </summary>
    public class PlayerInformation : ModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerInformation"/> class.
        /// </summary>
        public PlayerInformation()
        {
            this.HistoryPast = new List<HistoryPast>();
            this.FixturesSummary = new List<FixturesSummary>();
            this.Explain = new List<Explain>();
            this.HistorySummary = new List<HistorySummary>();
            this.Fixtures = new List<Fixture>();
            this.History = new List<History>();
        }

        /// <summary>
        /// Gets or sets the URL identifier.
        /// </summary>
        /// <value>
        /// The URL identifier.
        /// </value>
        public int UrlId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the history past.
        /// </summary>
        /// <value>
        /// The history past.
        /// </value>
        [JsonProperty("history_past")]
        public virtual IList<HistoryPast> HistoryPast { get; set; }

        /// <summary>
        /// Gets or sets the fixtures summary.
        /// </summary>
        /// <value>
        /// The fixtures summary.
        /// </value>
        [JsonProperty("fixtures_summary")]
        public virtual IList<FixturesSummary> FixturesSummary { get; set; }

        /// <summary>
        /// Gets or sets the explain.
        /// </summary>
        /// <value>
        /// The explain.
        /// </value>
        [JsonProperty("explain")]
        public virtual IList<Explain> Explain { get; set; }

        /// <summary>
        /// Gets or sets the history summary.
        /// </summary>
        /// <value>
        /// The history summary.
        /// </value>
        [JsonProperty("history_summary")]
        public virtual IList<HistorySummary> HistorySummary { get; set; }

        /// <summary>
        /// Gets or sets the fixtures.
        /// </summary>
        /// <value>
        /// The fixtures.
        /// </value>
        [JsonProperty("fixtures")]
        public virtual IList<Fixture> Fixtures { get; set; }

        /// <summary>
        /// Gets or sets the history.
        /// </summary>
        /// <value>
        /// The history.
        /// </value>
        [JsonProperty("history")]
        public virtual IList<History> History { get; set; }
    }
}
