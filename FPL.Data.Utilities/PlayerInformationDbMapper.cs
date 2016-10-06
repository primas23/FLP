// <copyright file="PlayerInformationDbMapper.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Data.Utilities
{
    using System.Collections.Generic;
    using System.Linq;

    using FPL.Data.Common.Contracts;
    using FPL.Data.Models.FullStats;

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
            // Player Information map
            PlayerInformation dataBasePlayerInformation = context
                .PlayerInformations
                .FirstOrDefault(pi => pi.UrlId == playerInformation.UrlId);

            if (dataBasePlayerInformation != null)
            {
                playerInformation.Id = dataBasePlayerInformation.Id;
            }

            // Explain Fixture map
            for (int i = 0; i < playerInformation.Explain.Count; i++)
            {
                playerInformation.Explain[i].ExplainFixture = MapEntity(playerInformation.Explain[i].ExplainFixture, context);
            }

            // Fixtures Summaries map
            playerInformation.FixturesSummary = MapEntities(playerInformation.FixturesSummary, context);

            // History map
            playerInformation.Histories = MapEntities(playerInformation.Histories, context);

            // History Summarry map
            playerInformation.HistorySummary = MapEntities(playerInformation.HistorySummary, context);

            // History Past map
            playerInformation.HistoryPast = MapEntities(playerInformation.HistoryPast, context);

            // Fixtures map
            playerInformation.Fixtures = MapEntities(playerInformation.Fixtures, context);
            
            return playerInformation;
        }

        /// <summary>
        /// Maps the entities by using the FantasyPremierLeagueId property.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entities">The entities.</param>
        /// <param name="context">The context.</param>
        /// <returns>The entities with the mapped data base id</returns>
        private static IList<TEntity> MapEntities<TEntity>(IList<TEntity> entities, FplContext context) where TEntity : class, IFantasyPremierLeagueId
        {
            for (int i = 0; i < entities.Count; i++)
            {
                TEntity playerEntity = entities[i];

                entities[i] = MapEntity(playerEntity, context);
            }

            return entities;
        }

        /// <summary>
        /// Maps the entity by using the FantasyPremierLeagueId property.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="context">The context.</param>
        /// <returns>The entity with the mapped data base id</returns>
        private static TEntity MapEntity<TEntity>(TEntity entity, FplContext context) where TEntity : class, IFantasyPremierLeagueId
        {
            TEntity dataBasEntity = context
                .Set<TEntity>()
                .FirstOrDefault(te => te.FantasyPremierLeagueId == entity.FantasyPremierLeagueId);

            if (dataBasEntity != null)
            {
                entity = dataBasEntity;
            }

            return entity;
        }
    }
}
