// <copyright file="ExplainDetails.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Explain Details class
    /// </summary>
    public class ExplainDetails : ModelBase
    {
        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        [JsonProperty("bonus")]
        public virtual Bonus Bonus { get; set; }

        /// <summary>
        /// Gets or sets the clean sheets.
        /// </summary>
        /// <value>
        /// The clean sheets.
        /// </value>
        [JsonProperty("clean_sheets")]
        public virtual CleanSheets CleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        [JsonProperty("minutes")]
        public virtual Minutes Minutes { get; set; }

        /// <summary>
        /// Gets or sets the goals scored.
        /// </summary>
        /// <value>
        /// The goals scored.
        /// </value>
        [JsonProperty("goals_scored")]
        public virtual GoalsScored GoalsScored { get; set; }
    }
}