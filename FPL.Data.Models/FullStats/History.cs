// <copyright file="History.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Models.FullStats
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The History class
    /// </summary>
    public class History : FullStatsBase
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
        /// Gets or sets the kickoff time.
        /// </summary>
        /// <value>
        /// The kickoff time.
        /// </value>
        [JsonProperty("kickoff_time")]
        public DateTime KickoffTime { get; set; }

        /// <summary>
        /// Gets or sets the kickoff time formatted.
        /// </summary>
        /// <value>
        /// The kickoff time formatted.
        /// </value>
        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

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
        /// Gets or sets a value indicating whether [was home].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [was home]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("was_home")]
        public bool WasHome { get; set; }

        /// <summary>
        /// Gets or sets the round.
        /// </summary>
        /// <value>
        /// The round.
        /// </value>
        [JsonProperty("round")]
        public int Round { get; set; }

        /// <summary>
        /// Gets or sets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the transfers balance.
        /// </summary>
        /// <value>
        /// The transfers balance.
        /// </value>
        [JsonProperty("transfers_balance")]
        public int TransfersBalance { get; set; }

        /// <summary>
        /// Gets or sets the selected.
        /// </summary>
        /// <value>
        /// The selected.
        /// </value>
        [JsonProperty("selected")]
        public int Selected { get; set; }

        /// <summary>
        /// Gets or sets the transfers in.
        /// </summary>
        /// <value>
        /// The transfers in.
        /// </value>
        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }

        /// <summary>
        /// Gets or sets the transfers out.
        /// </summary>
        /// <value>
        /// The transfers out.
        /// </value>
        [JsonProperty("transfers_out")]
        public int TransfersOut { get; set; }

        /// <summary>
        /// Gets or sets the loaned in.
        /// </summary>
        /// <value>
        /// The loaned in.
        /// </value>
        [JsonProperty("loaned_in")]
        public int LoanedIn { get; set; }

        /// <summary>
        /// Gets or sets the loaned out.
        /// </summary>
        /// <value>
        /// The loaned out.
        /// </value>
        [JsonProperty("loaned_out")]
        public int LoanedOut { get; set; }

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
        /// Gets or sets the index of the ict.
        /// </summary>
        /// <value>
        /// The index of the ict.
        /// </value>
        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        /// <summary>
        /// Gets or sets the index of the Electronics Arts.
        /// </summary>
        /// <value>
        /// The index of the Electronics Arts.
        /// </value>
        [JsonProperty("ea_index")]
        public int EaIndex { get; set; }

        /// <summary>
        /// Gets or sets the open play crosses.
        /// </summary>
        /// <value>
        /// The open play crosses.
        /// </value>
        [JsonProperty("open_play_crosses")]
        public int OpenPlayCrosses { get; set; }

        /// <summary>
        /// Gets or sets the big chances created.
        /// </summary>
        /// <value>
        /// The big chances created.
        /// </value>
        [JsonProperty("big_chances_created")]
        public int BigChancesCreated { get; set; }

        /// <summary>
        /// Gets or sets the clearances blocks interceptions.
        /// </summary>
        /// <value>
        /// The clearances blocks interceptions.
        /// </value>
        [JsonProperty("clearances_blocks_interceptions")]
        public int ClearancesBlocksInterceptions { get; set; }

        /// <summary>
        /// Gets or sets the recoveries.
        /// </summary>
        /// <value>
        /// The recoveries.
        /// </value>
        [JsonProperty("recoveries")]
        public int Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the key passes.
        /// </summary>
        /// <value>
        /// The key passes.
        /// </value>
        [JsonProperty("key_passes")]
        public int KeyPasses { get; set; }

        /// <summary>
        /// Gets or sets the tackles.
        /// </summary>
        /// <value>
        /// The tackles.
        /// </value>
        [JsonProperty("tackles")]
        public int Tackles { get; set; }

        /// <summary>
        /// Gets or sets the winning goals.
        /// </summary>
        /// <value>
        /// The winning goals.
        /// </value>
        [JsonProperty("winning_goals")]
        public int WinningGoals { get; set; }

        /// <summary>
        /// Gets or sets the attempted passes.
        /// </summary>
        /// <value>
        /// The attempted passes.
        /// </value>
        [JsonProperty("attempted_passes")]
        public int AttemptedPasses { get; set; }

        /// <summary>
        /// Gets or sets the completed passes.
        /// </summary>
        /// <value>
        /// The completed passes.
        /// </value>
        [JsonProperty("completed_passes")]
        public int CompletedPasses { get; set; }

        /// <summary>
        /// Gets or sets the penalties conceded.
        /// </summary>
        /// <value>
        /// The penalties conceded.
        /// </value>
        [JsonProperty("penalties_conceded")]
        public int PenaltiesConceded { get; set; }

        /// <summary>
        /// Gets or sets the big chances missed.
        /// </summary>
        /// <value>
        /// The big chances missed.
        /// </value>
        [JsonProperty("big_chances_missed")]
        public int BigChancesMissed { get; set; }

        /// <summary>
        /// Gets or sets the errors leading to goal.
        /// </summary>
        /// <value>
        /// The errors leading to goal.
        /// </value>
        [JsonProperty("errors_leading_to_goal")]
        public int ErrorsLeadingToGoal { get; set; }

        /// <summary>
        /// Gets or sets the errors leading to goal attempt.
        /// </summary>
        /// <value>
        /// The errors leading to goal attempt.
        /// </value>
        [JsonProperty("errors_leading_to_goal_attempt")]
        public int ErrorsLeadingToGoalAttempt { get; set; }

        /// <summary>
        /// Gets or sets the tackled.
        /// </summary>
        /// <value>
        /// The tackled.
        /// </value>
        [JsonProperty("tackled")]
        public int Tackled { get; set; }

        /// <summary>
        /// Gets or sets the offside.
        /// </summary>
        /// <value>
        /// The offside.
        /// </value>
        [JsonProperty("offside")]
        public int Offside { get; set; }

        /// <summary>
        /// Gets or sets the target missed.
        /// </summary>
        /// <value>
        /// The target missed.
        /// </value>
        [JsonProperty("target_missed")]
        public int TargetMissed { get; set; }

        /// <summary>
        /// Gets or sets the fouls.
        /// </summary>
        /// <value>
        /// The fouls.
        /// </value>
        [JsonProperty("fouls")]
        public int Fouls { get; set; }

        /// <summary>
        /// Gets or sets the dribbles.
        /// </summary>
        /// <value>
        /// The dribbles.
        /// </value>
        [JsonProperty("dribbles")]
        public int Dribbles { get; set; }

        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// The element.
        /// </value>
        [JsonProperty("element")]
        public int Element { get; set; }

        /// <summary>
        /// Gets or sets the fixture.
        /// </summary>
        /// <value>
        /// The fixture.
        /// </value>
        [JsonProperty("fixture")]
        public int Fixture { get; set; }

        /// <summary>
        /// Gets or sets the opponent team.
        /// </summary>
        /// <value>
        /// The opponent team.
        /// </value>
        [JsonProperty("opponent_team")]
        public int OpponentTeam { get; set; }
    }
}