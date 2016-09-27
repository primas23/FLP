// <copyright file="FantasyPremierLeague.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.WebCrawler
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;

    using Newtonsoft.Json;

    using Data.Models.FullStats;

    /// <summary>
    /// The FantasyPremierLeague static
    /// </summary>
    public static class FantasyPremierLeague
    {
        /// <summary>
        /// The simple elements to replace
        /// </summary>
        private static readonly IDictionary<string, string> _simpleElementsToReplace = new Dictionary<string, string>
        {
            { Environment.NewLine, string.Empty },
            { "team_h_score", "team_home_score" },
            { "team_a_score", "team_away_score" },
            { "team_a", "team_away" },
            { "team_h", "team_home" },
            { "\"explain\":[{\"explain\"", "\"explain\":[{\"explainDetails\"" },
            { "\"a\":", "\"away\":" },
            { "\"h\":", "\"home\":" }
        };

        /// <summary>
        /// Gets the player information.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A PlayerInformation Class</returns>
        /// <exception cref="System.NullReferenceException">
        /// No fixture
        /// or
        /// No history summary
        /// </exception>
        public static PlayerInformation GetPlayerInformation(int id)
        {
            PlayerInformation info = new PlayerInformation();

            string url = Constants.FantasyPremierLeagueUrl + id;
            WebRequest webRequest = WebRequest.Create(url);

            using (StreamReader objStream = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                string json = objStream.ReadToEnd();

                json = JsonReplaceSimpleNames(json);
                json = ReplaceFixture(json, Constants.HistorySummaryPattern, Constants.HistorySummaryValueToAdd, "No history summary");
                json = ReplaceFixture(json, Constants.ExplainFixturePattern, Constants.ExplainFixtureValueToAdd, "No fixture");

                info = JsonConvert.DeserializeObject<PlayerInformation>(json);
            }

            return info;
        }

        /// <summary>
        /// Replaces the fixture with cooresponding pattern.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="pattern">The pattern.</param>
        /// <param name="valueToReplace">The value to replace.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>The json with the replaced value.</returns>
        /// <exception cref="NullReferenceException">The supplied exception message</exception>
        private static string ReplaceFixture(string json, string pattern, string valueToReplace, string errorMessage)
        {
            Regex historyFixtureRegex = new Regex(pattern, RegexOptions.IgnoreCase);
            Match historyFixtureMatch = historyFixtureRegex.Match(json);

            if (historyFixtureMatch.Success)
            {
                json = json.Replace(historyFixtureMatch.Value, historyFixtureMatch.Value + valueToReplace);
            }
            else
            {
                throw new NullReferenceException(errorMessage);
            }
            return json;
        }

        /// <summary>
        /// Replaces the short names with their long name representatives
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>The json with the replaced value.</returns>
        private static string JsonReplaceSimpleNames(string json)
        {
            foreach (KeyValuePair<string, string> pair in _simpleElementsToReplace)
            {
                json = json.Replace(pair.Key, pair.Value);
            }

            return json;
        }
    }
}
