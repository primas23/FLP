// <copyright file="Minutes.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Minutes class
    /// </summary>
    public class Minutes : FullStatsBase
    {
        /// <summary>
        /// Gets or sets the points.
        /// </summary>
        /// <value>
        /// The points.
        /// </value>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}