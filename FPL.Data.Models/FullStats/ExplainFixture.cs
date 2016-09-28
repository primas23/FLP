// <copyright file="ExplainFixture.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using FPL.Data.Common.Contracts;

    /// <summary>
    /// The ExplainFixture class
    /// </summary>
    public class ExplainFixture : ModelBase, IFantasyPremierLeagueId
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExplainFixture"/> class.
        /// </summary>
        public ExplainFixture()
        {
            this.Explains = new List<Explain>();
        }

        /// <summary>
        /// Gets or sets the explains.
        /// </summary>
        /// <value>
        /// The explains.
        /// </value>
        public virtual IList<Explain> Explains { get; set; }

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
        /// Gets or sets a value indicating whether this <see cref="ExplainFixture"/> is started.
        /// </summary>
        /// <value>
        ///   <c>true</c> if started; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("started")]
        public bool Started { get; set; }

        /// <summary>
        /// Gets or sets the event day.
        /// </summary>
        /// <value>
        /// The event day.
        /// </value>
        [JsonProperty("event_day")]
        public int EventDay { get; set; }

        /// <summary>
        /// Gets or sets the deadline time.
        /// </summary>
        /// <value>
        /// The deadline time.
        /// </value>
        [JsonProperty("deadline_time")]
        public DateTime DeadlineTime { get; set; }

        /// <summary>
        /// Gets or sets the deadline time formatted.
        /// </summary>
        /// <value>
        /// The deadline time formatted.
        /// </value>
        [JsonProperty("deadline_time_formatted")]
        public string DeadlineTimeFormatted { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        [JsonProperty("stats")]
        public virtual IList<Stat> Stats { get; set; }

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
        public int TeamHomeScore { get; set; }

        /// <summary>
        /// Gets or sets the team away score.
        /// </summary>
        /// <value>
        /// The team away score.
        /// </value>
        [JsonProperty("team_away_score")]
        public int TeamAwayScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ExplainFixture"/> is finished.
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