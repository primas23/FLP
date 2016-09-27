// <copyright file="Constants.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.WebCrawler
{
    /// <summary>
    /// Constants for the FPL.WebCrawler
    /// </summary>
    internal class Constants
    {
        /// <summary>
        /// The fantasy premier league URL
        /// </summary>
        internal const string FantasyPremierLeagueUrl = "https://fantasy.premierleague.com/drf/element-summary/";

        /// <summary>
        /// The history summary pattern which matches the element that starts with history_summary and ends with fixture
        /// </summary>
        internal const string HistorySummaryPattern = "\"history_summary\"(.*?)\"fixture";

        /// <summary>
        /// The history summary value to add after the regex match
        /// </summary>
        internal const string HistorySummaryValueToAdd = "_history_summary";

        /// <summary>
        /// The explain fixture pattern which matches the element that starts with explain and ends with fixture
        /// </summary>
        internal const string ExplainFixturePattern = "\"explain\"(.*?)\"fixture";

        /// <summary>
        /// The explain fixture value to add after the regex math
        /// </summary>
        internal const string ExplainFixtureValueToAdd = "Explain";
    }
}
