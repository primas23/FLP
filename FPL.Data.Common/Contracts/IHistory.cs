// <copyright file="IHistory.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Common.Contracts
{
    using System;

    public interface IHistory : IFantasyPremierLeagueId
    {
        /// <summary>
        /// Gets or sets the kickoff time.
        /// </summary>
        /// <value>
        /// The kickoff time.
        /// </value>
        DateTime KickoffTime { get; set; }

        /// <summary>
        /// Gets or sets the kickoff time formatted.
        /// </summary>
        /// <value>
        /// The kickoff time formatted.
        /// </value>
        string KickoffTimeFormatted { get; set; }

        /// <summary>
        /// Gets or sets the team home score.
        /// </summary>
        /// <value>
        /// The team home score.
        /// </value>
        int TeamHomeScore { get; set; }

        /// <summary>
        /// Gets or sets the team away score.
        /// </summary>
        /// <value>
        /// The team away score.
        /// </value>
        int TeamAwayScore { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [was home].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [was home]; otherwise, <c>false</c>.
        /// </value>
        bool WasHome { get; set; }

        /// <summary>
        /// Gets or sets the round.
        /// </summary>
        /// <value>
        /// The round.
        /// </value>
        int Round { get; set; }

        /// <summary>
        /// Gets or sets the total points.
        /// </summary>
        /// <value>
        /// The total points.
        /// </value>
        int TotalPoints { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        int Value { get; set; }

        /// <summary>
        /// Gets or sets the transfers balance.
        /// </summary>
        /// <value>
        /// The transfers balance.
        /// </value>
        int TransfersBalance { get; set; }

        /// <summary>
        /// Gets or sets the selected.
        /// </summary>
        /// <value>
        /// The selected.
        /// </value>
        int Selected { get; set; }

        /// <summary>
        /// Gets or sets the transfers in.
        /// </summary>
        /// <value>
        /// The transfers in.
        /// </value>
        int TransfersIn { get; set; }

        /// <summary>
        /// Gets or sets the transfers out.
        /// </summary>
        /// <value>
        /// The transfers out.
        /// </value>
        int TransfersOut { get; set; }

        /// <summary>
        /// Gets or sets the loaned in.
        /// </summary>
        /// <value>
        /// The loaned in.
        /// </value>
        int LoanedIn { get; set; }

        /// <summary>
        /// Gets or sets the loaned out.
        /// </summary>
        /// <value>
        /// The loaned out.
        /// </value>
        int LoanedOut { get; set; }

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        int Minutes { get; set; }

        /// <summary>
        /// Gets or sets the goals scored.
        /// </summary>
        /// <value>
        /// The goals scored.
        /// </value>
        int GoalsScored { get; set; }

        /// <summary>
        /// Gets or sets the assists.
        /// </summary>
        /// <value>
        /// The assists.
        /// </value>
        int Assists { get; set; }

        /// <summary>
        /// Gets or sets the clean sheets.
        /// </summary>
        /// <value>
        /// The clean sheets.
        /// </value>
        int CleanSheets { get; set; }

        /// <summary>
        /// Gets or sets the goals conceded.
        /// </summary>
        /// <value>
        /// The goals conceded.
        /// </value>
        int GoalsConceded { get; set; }

        /// <summary>
        /// Gets or sets the own goals.
        /// </summary>
        /// <value>
        /// The own goals.
        /// </value>
        int OwnGoals { get; set; }

        /// <summary>
        /// Gets or sets the penalties saved.
        /// </summary>
        /// <value>
        /// The penalties saved.
        /// </value>
        int PenaltiesSaved { get; set; }

        /// <summary>
        /// Gets or sets the penalties missed.
        /// </summary>
        /// <value>
        /// The penalties missed.
        /// </value>
        int PenaltiesMissed { get; set; }

        /// <summary>
        /// Gets or sets the yellow cards.
        /// </summary>
        /// <value>
        /// The yellow cards.
        /// </value>
        int YellowCards { get; set; }

        /// <summary>
        /// Gets or sets the red cards.
        /// </summary>
        /// <value>
        /// The red cards.
        /// </value>
        int RedCards { get; set; }

        /// <summary>
        /// Gets or sets the saves.
        /// </summary>
        /// <value>
        /// The saves.
        /// </value>
        int Saves { get; set; }

        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the BPS.
        /// </summary>
        /// <value>
        /// The BPS.
        /// </value>
        int Bps { get; set; }

        /// <summary>
        /// Gets or sets the influence.
        /// </summary>
        /// <value>
        /// The influence.
        /// </value>
        string Influence { get; set; }

        /// <summary>
        /// Gets or sets the creativity.
        /// </summary>
        /// <value>
        /// The creativity.
        /// </value>
        string Creativity { get; set; }

        /// <summary>
        /// Gets or sets the threat.
        /// </summary>
        /// <value>
        /// The threat.
        /// </value>
        string Threat { get; set; }

        /// <summary>
        /// Gets or sets the index of the Influence, Creativity and Threat.
        /// </summary>
        /// <value>
        /// The index of the Influence, Creativity and Threat.
        /// </value>
        string IctIndex { get; set; }

        /// <summary>
        /// Gets or sets the index of the Electronics Arts.
        /// </summary>
        /// <value>
        /// The index of the Electronics Arts.
        /// </value>
        int EaIndex { get; set; }

        /// <summary>
        /// Gets or sets the open play crosses.
        /// </summary>
        /// <value>
        /// The open play crosses.
        /// </value>
        int OpenPlayCrosses { get; set; }

        /// <summary>
        /// Gets or sets the big chances created.
        /// </summary>
        /// <value>
        /// The big chances created.
        /// </value>
        int BigChancesCreated { get; set; }

        /// <summary>
        /// Gets or sets the clearances blocks interceptions.
        /// </summary>
        /// <value>
        /// The clearances blocks interceptions.
        /// </value>
        int ClearancesBlocksInterceptions { get; set; }

        /// <summary>
        /// Gets or sets the recoveries.
        /// </summary>
        /// <value>
        /// The recoveries.
        /// </value>
        int Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the key passes.
        /// </summary>
        /// <value>
        /// The key passes.
        /// </value>
        int KeyPasses { get; set; }

        /// <summary>
        /// Gets or sets the tackles.
        /// </summary>
        /// <value>
        /// The tackles.
        /// </value>
        int Tackles { get; set; }

        /// <summary>
        /// Gets or sets the winning goals.
        /// </summary>
        /// <value>
        /// The winning goals.
        /// </value>
        int WinningGoals { get; set; }

        /// <summary>
        /// Gets or sets the attempted passes.
        /// </summary>
        /// <value>
        /// The attempted passes.
        /// </value>
        int AttemptedPasses { get; set; }

        /// <summary>
        /// Gets or sets the completed passes.
        /// </summary>
        /// <value>
        /// The completed passes.
        /// </value>
        int CompletedPasses { get; set; }

        /// <summary>
        /// Gets or sets the penalties conceded.
        /// </summary>
        /// <value>
        /// The penalties conceded.
        /// </value>
        int PenaltiesConceded { get; set; }

        /// <summary>
        /// Gets or sets the big chances missed.
        /// </summary>
        /// <value>
        /// The big chances missed.
        /// </value>
        int BigChancesMissed { get; set; }

        /// <summary>
        /// Gets or sets the errors leading to goal.
        /// </summary>
        /// <value>
        /// The errors leading to goal.
        /// </value>
        int ErrorsLeadingToGoal { get; set; }

        /// <summary>
        /// Gets or sets the errors leading to goal attempt.
        /// </summary>
        /// <value>
        /// The errors leading to goal attempt.
        /// </value>
        int ErrorsLeadingToGoalAttempt { get; set; }

        /// <summary>
        /// Gets or sets the tackled.
        /// </summary>
        /// <value>
        /// The tackled.
        /// </value>
        int Tackled { get; set; }

        /// <summary>
        /// Gets or sets the offside.
        /// </summary>
        /// <value>
        /// The offside.
        /// </value>
        int Offside { get; set; }

        /// <summary>
        /// Gets or sets the target missed.
        /// </summary>
        /// <value>
        /// The target missed.
        /// </value>
        int TargetMissed { get; set; }

        /// <summary>
        /// Gets or sets the fouls.
        /// </summary>
        /// <value>
        /// The fouls.
        /// </value>
        int Fouls { get; set; }

        /// <summary>
        /// Gets or sets the dribbles.
        /// </summary>
        /// <value>
        /// The dribbles.
        /// </value>
        int Dribbles { get; set; }

        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// The element.
        /// </value>
        int Element { get; set; }

        /// <summary>
        /// Gets or sets the fixture.
        /// </summary>
        /// <value>
        /// The fixture.
        /// </value>
        int Fixture { get; set; }

        /// <summary>
        /// Gets or sets the opponent team.
        /// </summary>
        /// <value>
        /// The opponent team.
        /// </value>
        int OpponentTeam { get; set; }

        /// <summary>
        /// Gets or sets the player information identifier.
        /// </summary>
        /// <value>
        /// The player information identifier.
        /// </value>
        int PlayerInformationId { get; set; }

        /// <summary>
        /// Gets or sets the player information.
        /// </summary>
        /// <value>
        /// The player information.
        /// </value>
        IPlayerInformation PlayerInformation { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the created on date.
        /// </summary>
        /// <value>
        /// The created on date.
        /// </value>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is deleted.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is deleted; otherwise, <c>false</c>.
        /// </value>
        bool IsDeleted { get; set; }
    }
}