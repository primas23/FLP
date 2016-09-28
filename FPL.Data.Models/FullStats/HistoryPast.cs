// <copyright file="HistoryPast.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// The past history class
    /// </summary>
    public class HistoryPast : FullStatsBase
    {   
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int FantasyPremierLeagueId { get; set; }

        /// <summary>
        /// Gets or sets the name of the season.
        /// </summary>
        /// <value>
        /// The name of the season.
        /// </value>
        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        /// <summary>
        /// Gets or sets the element code.
        /// </summary>
        /// <value>
        /// The element code.
        /// </value>
        [JsonProperty("element_code")]
        public int ElementCode { get; set; }

        /// <summary>
        /// Gets or sets the start cost.
        /// </summary>
        /// <value>
        /// The start cost.
        /// </value>
        [JsonProperty("start_cost")]
        public int StartCost { get; set; }

        /// <summary>
        /// Gets or sets the end cost.
        /// </summary>
        /// <value>
        /// The end cost.
        /// </value>
        [JsonProperty("end_cost")]
        public int EndCost { get; set; }

        /// <summary>
        /// Gets or sets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        /// <summary>
        /// Gets or sets the goals scored.
        /// </summary>
        /// <value>
        /// The goals scored.
        /// </value>
        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        /// <summary>
        /// Gets or sets the assists.
        /// </summary>
        /// <value>
        /// The assists.
        /// </value>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// Gets or sets the clean sheets.
        /// </summary>
        /// <value>
        /// The clean sheets.
        /// </value>
        [JsonProperty("clean_sheets")]
        public int CleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the goals conceded.
        /// </summary>
        /// <value>
        /// The goals conceded.
        /// </value>
        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        /// <summary>
        /// Gets or sets the own goals.
        /// </summary>
        /// <value>
        /// The own goals.
        /// </value>
        [JsonProperty("own_goals")]
        public int OwnGoals { get; set; }

        /// <summary>
        /// Gets or sets the penalties saved.
        /// </summary>
        /// <value>
        /// The penalties saved.
        /// </value>
        [JsonProperty("penalties_saved")]
        public int PenaltiesSaved { get; set; }

        /// <summary>
        /// Gets or sets the penalties missed.
        /// </summary>
        /// <value>
        /// The penalties missed.
        /// </value>
        [JsonProperty("penalties_missed")]
        public int PenaltiesMissed { get; set; }

        /// <summary>
        /// Gets or sets the yellow cards.
        /// </summary>
        /// <value>
        /// The yellow cards.
        /// </value>
        [JsonProperty("yellow_cards")]
        public int YellowCards { get; set; }

        /// <summary>
        /// Gets or sets the red cards.
        /// </summary>
        /// <value>
        /// The red cards.
        /// </value>
        [JsonProperty("red_cards")]
        public int RedCards { get; set; }

        /// <summary>
        /// Gets or sets the saves.
        /// </summary>
        /// <value>
        /// The saves.
        /// </value>
        [JsonProperty("saves")]
        public int Saves { get; set; }

        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        [JsonProperty("bonus")]
        public int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the BPS.
        /// </summary>
        /// <value>
        /// The BPS.
        /// </value>
        [JsonProperty("bps")]
        public int Bps { get; set; }

        /// <summary>
        /// Gets or sets the influence.
        /// </summary>
        /// <value>
        /// The influence.
        /// </value>
        [JsonProperty("influence")]
        public string Influence { get; set; }

        /// <summary>
        /// Gets or sets the creativity.
        /// </summary>
        /// <value>
        /// The creativity.
        /// </value>
        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        /// <summary>
        /// Gets or sets the threat.
        /// </summary>
        /// <value>
        /// The threat.
        /// </value>
        [JsonProperty("threat")]
        public string Threat { get; set; }

        /// <summary>
        /// Gets or sets the index of the Influence, Creativity and Threat.
        /// </summary>
        /// <value>
        /// The index of the Influence, Creativity and Threat.
        /// </value>
        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        /// <summary>
        /// Gets or sets the index of the electronic arts.
        /// </summary>
        /// <value>
        /// The index of the electronic arts.
        /// </value>
        [JsonProperty("ea_index")]
        public int EaIndex { get; set; }

        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        /// <value>
        /// The season.
        /// </value>
        [JsonProperty("season")]
        public int Season { get; set; }
    }
}