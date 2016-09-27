﻿// <copyright file="PenaltiesSaved.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The Penalties Saved
    /// </summary>
    public class PenaltiesSaved : FullStatsBase
    {
        /// <summary>
        /// Gets or sets the away.
        /// </summary>
        /// <value>
        /// The away.
        /// </value>
        [JsonProperty("away")]
        public IList<Away> Away { get; set; }

        /// <summary>
        /// Gets or sets the home.
        /// </summary>
        /// <value>
        /// The home.
        /// </value>
        [JsonProperty("home")]
        public IList<Home> Home { get; set; }
    }
}