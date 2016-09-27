// <copyright file="PlayerInformationDbMapper.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Common
{
    using System.Linq;

    using Models.FullStats;

    /// <summary>
    /// Maps the PlayerInformation class to data base
    /// </summary>
    public static class PlayerInformationDbMapper
    {
        /// <summary>
        /// Maps the player information from data base.
        /// </summary>
        /// <param name="playerInformation">The player information.</param>
        /// <param name="context">The context.</param>
        /// <returns>The mapped player information</returns>
        public static PlayerInformation MapPlayerInformationFromDataBase(PlayerInformation playerInformation, FplContext context)
        {
            // Player Information
            PlayerInformation dbPlayerInformation = context
                .PlayerInformations
                .FirstOrDefault(pi => pi.UrlId == playerInformation.UrlId);

            if (dbPlayerInformation != null)
            {
                playerInformation.Id = dbPlayerInformation.Id;
            }

            // Explain Fixture map
            for (int i = 0; i < playerInformation.Explain.Count; i++)
            {
                ExplainFixture playerExplainFixture = playerInformation
                    .Explain[i]
                    .ExplainFixture;

                ExplainFixture dbExplainFixture = context
                    .ExplainFixtures
                    .FirstOrDefault(ef => ef.FantasyPremierLeagueId == playerExplainFixture.FantasyPremierLeagueId);

                if (dbExplainFixture != null)
                {
                    playerInformation.Explain[i].ExplainFixture = dbExplainFixture;
                }
            }

            // Fixtures Summaries map
            for (int i = 0; i < playerInformation.FixturesSummary.Count; i++)
            {
                FixturesSummary playerFixturesSummary = playerInformation.FixturesSummary[i];

                FixturesSummary dbFixturesSummary = context
                    .FixturesSummaries
                    .FirstOrDefault(fs => fs.FantasyPremierLeagueId == playerFixturesSummary.FantasyPremierLeagueId);

                if (dbFixturesSummary != null)
                {
                    playerInformation.FixturesSummary[i] = dbFixturesSummary;
                }
            }

            return playerInformation;
        }
    }
}
