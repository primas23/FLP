// <copyright file="Assists.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The Player Assists class
    /// </summary>
    public class Assists : ModelBase
    {
        /// <summary>
        /// Gets or sets the away assists.
        /// </summary>
        /// <value>
        /// The away.
        /// </value>
        [JsonProperty("away")]
        public virtual IList<object> Away { get; set; }

        /// <summary>
        /// Gets or sets the home assists.
        /// </summary>
        /// <value>
        /// The home.
        /// </value>
        [JsonProperty("home")]
        public virtual IList<Home> Home { get; set; }
    }
}