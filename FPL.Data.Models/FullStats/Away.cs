// <copyright file="Away.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Player Away stats class
    /// </summary>
    public class Away : FullStatsBase
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// The element.
        /// </value>
        [JsonProperty("element")]
        public int Element { get; set; }
    }
}