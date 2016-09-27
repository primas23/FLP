// <copyright file="Saves.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The Saves class
    /// </summary>
    public class Saves : ModelBase
    {
        /// <summary>
        /// Gets or sets the away.
        /// </summary>
        /// <value>
        /// The away.
        /// </value>
        [JsonProperty("away")]
        public virtual IList<Away> Away { get; set; }

        /// <summary>
        /// Gets or sets the home.
        /// </summary>
        /// <value>
        /// The home.
        /// </value>
        [JsonProperty("home")]
        public virtual IList<Home> Home { get; set; }
    }
}