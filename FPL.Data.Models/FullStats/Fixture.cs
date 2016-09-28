// <copyright file="Fixture.cs" company="Primas">
//     Company copyright tag.
// </copyright>

using System.Collections.Generic;

namespace FPL.Data.Models.FullStats
{
    using System;

    using Newtonsoft.Json;

    using FPL.Data.Common.Contracts;

    /// <summary>
    /// Fixture class
    /// </summary>
    public class Fixture : ModelBase, IFantasyPremierLeagueId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fixture"/> class.
        /// </summary>
        public Fixture()
        {
            this.PlayerInformations = new List<PlayerInformation>();
        }

        /// <summary>
        /// Gets or sets the player informations.
        /// </summary>
        /// <value>
        /// The player informations.
        /// </value>
        public IList<PlayerInformation> PlayerInformations { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int FantasyPremierLeagueId { get; set; }

        /// <summary>
        /// Gets or sets the kickoff time formatted.
        /// </summary>
        /// <value>
        /// The kickoff time formatted.
        /// </value>
        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        /// <value>
        /// The name of the event.
        /// </value>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the name of the opponent.
        /// </summary>
        /// <value>
        /// The name of the opponent.
        /// </value>
        [JsonProperty("opponent_name")]
        public string OpponentName { get; set; }

        /// <summary>
        /// Gets or sets the short name of the opponent.
        /// </summary>
        /// <value>
        /// The short name of the opponent.
        /// </value>
        [JsonProperty("opponent_short_name")]
        public string OpponentShortName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is home.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is home; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_home")]
        public bool IsHome { get; set; }

        /// <summary>
        /// Gets or sets the difficulty.
        /// </summary>
        /// <value>
        /// The difficulty.
        /// </value>
        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the kickoff time.
        /// </summary>
        /// <value>
        /// The kickoff time.
        /// </value>
        [JsonProperty("kickoff_time")]
        public DateTime KickoffTime { get; set; }

        /// <summary>
        /// Gets or sets the team home score.
        /// </summary>
        /// <value>
        /// The team home score.
        /// </value>
        [JsonProperty("team_home_score")]
        public object TeamHomeScore { get; set; }

        /// <summary>
        /// Gets or sets the team away score.
        /// </summary>
        /// <value>
        /// The team away score.
        /// </value>
        [JsonProperty("team_away_score")]
        public object TeamAwayScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Fixture"/> is finished.
        /// </summary>
        /// <value>
        ///   <c>true</c> if finished; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [provisional start time].
        /// </summary>
        /// <value>
        /// <c>true</c> if [provisional start time]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("provisional_start_time")]
        public bool ProvisionalStartTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [finished provisional].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [finished provisional]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("finished_provisional")]
        public bool FinishedProvisional { get; set; }

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        /// <value>
        /// The event.
        /// </value>
        [JsonProperty("event")]
        public int Event { get; set; }

        /// <summary>
        /// Gets or sets the team away.
        /// </summary>
        /// <value>
        /// The team away.
        /// </value>
        [JsonProperty("team_away")]
        public int TeamAway { get; set; }

        /// <summary>
        /// Gets or sets the team home.
        /// </summary>
        /// <value>
        /// The team home.
        /// </value>
        [JsonProperty("team_home")]
        public int TeamHome { get; set; }
    }
}