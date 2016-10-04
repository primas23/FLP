// <copyright file="FantasyPremierLeagueInfoSummaryTests.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace FPL.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MSTestExtensions;

    using FPL.Data.Models.FullStats;
    using FPL.Data.Models.SummaryStats;
    
    /// <summary>
    /// Tests for FantasyPremierLeagueInfoSummary class
    /// </summary>
    [TestClass]
    public class FantasyPremierLeagueInfoSummaryTests
    {
        /// <summary>
        /// Should throw exception when null is provided in constructor.
        /// </summary>
        [TestMethod]
        public void ShoudThrowExceptionWhenNullIsProvidedInConstructor()
        {
            ThrowsAssert.Throws<ArgumentNullException>(() => new FantasyPremierLeagueInfoSummary(null));
        }


        [TestMethod]
        public void ShoudNotExceptNull()
        {
            // TODO: Finitsh the tests

            PlayerInformation playerInformation = new PlayerInformation { FirstName = null };
            FantasyPremierLeagueInfoSummary summery = new FantasyPremierLeagueInfoSummary(playerInformation);
            string asd = summery.FirstName;
            ThrowsAssert.Throws<ArgumentNullException>(() => asd = summery.FirstName);
        }
    }
}
